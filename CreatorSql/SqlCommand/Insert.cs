using CreatorSql.Context;
using LinqToDB.SchemaProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatorSql.SqlCommand
{
    public class Insert : CommandBase
    {

        public Insert(string tableName, object valores)
        {
            this._className = tableName;

            var dictionary = (Dictionary<string, object>)valores;

            foreach (var valor in dictionary.Where(d => d.Key == "value").ToList())
            {
                KeyValuePair<String, object> field = new KeyValuePair<String, object>(valor.Key, valor.Value);

                this.Fields.Add(field);
            }
        }

        public override string GenerateScript()
        {
            System.Text.StringBuilder script = new StringBuilder();

            var context = new MainContext();
            var schemaProvider = context.DataProvider.GetSchemaProvider();
            var schema = schemaProvider.GetSchema(context, new GetSchemaOptions());
            var tableScheme = schema.Tables.Where(c => c.TableName == this._className).FirstOrDefault();
            

            var values = (List<object>)this.Fields[0].Value;
            for (int i = 0; i < values.Count; i++)
            {
                var fields = (Dictionary<string, object>)values[i];

                script.AppendLine("INSERT INTO " + this.ClassName);

                System.Text.StringBuilder colunas = new StringBuilder();
                System.Text.StringBuilder valores = new StringBuilder();

                var primeiraLinha = true;

                colunas.AppendLine("(");
                valores.AppendLine(")VALUES(");

                foreach (var field in fields)
                {
                    var columnProperty = tableScheme.Columns.Where(c => c.ColumnName == field.Key).FirstOrDefault();

                    if (columnProperty != null)
                    {
                        if (!primeiraLinha)
                        {
                            colunas.AppendLine(",");
                            valores.AppendLine(",");
                        }
                        else
                        {
                            primeiraLinha = false;
                        }

                        colunas.AppendLine($"\t {field.Key}");
                        if (field.Value == null)
                        {
                            valores.AppendLine($"\t NULL");
                        }
                        else
                        {
                            if (columnProperty.DataType == LinqToDB.DataType.VarChar ||
                                columnProperty.DataType == LinqToDB.DataType.Date ||
                                columnProperty.DataType == LinqToDB.DataType.DateTime ||
                                columnProperty.DataType == LinqToDB.DataType.NVarChar ||
                                columnProperty.DataType == LinqToDB.DataType.NChar ||
                                columnProperty.DataType == LinqToDB.DataType.Text ||
                                columnProperty.DataType == LinqToDB.DataType.NText)
                            {

                                valores.AppendLine($"\t '{field.Value?.ToString()}'");

                            }
                            else if (columnProperty.DataType == LinqToDB.DataType.Double)
                            {

                                valores.AppendLine($"\t {field.Value?.ToString().Replace(',', '.')}");

                            }
                            else
                            {
                                valores.AppendLine($"\t {field.Value?.ToString() ?? "null"}");
                            }
                      
                        }

                    }
                }
                valores.AppendLine(");");

                script.Append(colunas);
                script.Append(valores);

                script.Append(Environment.NewLine);
            }
            return script.ToString();
        }
    }
}
