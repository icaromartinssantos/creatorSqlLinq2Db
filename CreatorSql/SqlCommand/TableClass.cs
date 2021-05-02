using CreatorSql.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatorSql.SqlCommand
{
    public class TableClass : CommandBase
    {

        public TableClass(string tableName, List<Campos> campos)
        {
            this._className = tableName;

            foreach (var campo in campos)
            {
                KeyValuePair<String, object> field = new KeyValuePair<String, object>(campo.Name, campo.Type);

                this.Fields.Add(field);
            }
        }

        public override string GenerateScript()
        {
            System.Text.StringBuilder script = new StringBuilder();
            script.AppendLine("CREATE TABLE " + this.ClassName);
            script.AppendLine("(");
            for (int i = 0; i < this.Fields.Count; i++)
            {
                KeyValuePair<String, object> field = this.Fields[i];

                if (dataMapper.ContainsKey(field.Value.ToString()))
                {
                    script.Append("\t " + field.Key + " " + dataMapper[field.Value.ToString()]);
                }
                else
                {
                    // Complex Type? 
                    script.Append("\t " + field.Key + " BIGINT");
                }

                if (i != this.Fields.Count - 1)
                {
                    script.Append(",");
                }

                script.Append(Environment.NewLine);
            }

            script.AppendLine(")");

            return script.ToString();
        }
    }
}
