using CreatorSql.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatorSql.SqlCommand
{
    public class AlterTable : CommandBase
    {
        public AlterTable(string tableName, List<Campos> campos)
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
            for (int i = 0; i < this.Fields.Count; i++)
            {
                KeyValuePair<String, object> field = this.Fields[i];

                if (dataMapper.ContainsKey(field.Value.ToString()))
                {
                    script.Append($"\t ALTER TABLE {this.ClassName} ADD COLUMN {field.Key} {dataMapper[field.Value.ToString()]};\n");
                }


                script.Append(Environment.NewLine);
            }
            return script.ToString();
        }
    }
}
