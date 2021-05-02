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
                script.AppendLine("(");
                foreach (var field in fields)
                {
                    var column = tableScheme.Columns.Where(c => c.ColumnName == field.Key).FirstOrDefault();

                    if (column != null)
                    {
                        script.AppendLine($"\t ,{field.Key}");
                    }
                }
                script.AppendLine(")VALUES(");
                foreach (var field in fields)
                {
                    var column = tableScheme.Columns.Where(c => c.ColumnName == field.Key).FirstOrDefault();

                    if (column != null)
                    {
                        if (field.Value == null)
                        {
                            script.AppendLine($"\t ,NULL");
                        }
                        else
                        {
                            if (column.DataType == LinqToDB.DataType.VarChar || 
                                column.DataType == LinqToDB.DataType.Date ||
                                column.DataType == LinqToDB.DataType.DateTime ||
                                column.DataType == LinqToDB.DataType.NVarChar || 
                                column.DataType == LinqToDB.DataType.NChar ||
                                column.DataType == LinqToDB.DataType.Text ||
                                column.DataType == LinqToDB.DataType.NText)
                            {

                                script.AppendLine($"\t ,'{field.Value?.ToString()}'");

                            }
                            else if (column.DataType == LinqToDB.DataType.Double)
                            {

                                script.AppendLine($"\t ,{field.Value?.ToString().Replace(',','.')}");

                            }
                            else
                            {
                                script.AppendLine($"\t ,{field.Value?.ToString() ?? "null"}");
                            }
                        }
                    }
                }
                script.AppendLine(");");


                script.Append(Environment.NewLine);
            }
            return script.ToString();
        }
    }
}
