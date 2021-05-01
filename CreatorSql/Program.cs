using CreatorSql.Context;
using CreatorSql.Dto;
using LinqToDB.Data;
using LinqToDB.Mapping;
using LinqToDB.SchemaProvider;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CreatorSql
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new MainContext();

           var json = @"{
    'name': 'decisionpadrao',
    'title': 'DecisionPadrao',
    'internal': false,
    'fields': [
        {
            'name': 'nf',
            'type': 'Integer',
            'label': 'NF',
            'size': '100%',
            'order': 0,
            'required': false,
            'validationRegex': '',
            'mask': '0',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'valor_solicitado_r',
            'type': 'Double',
            'label': 'Valor Solicitado R$',
            'size': '100%',
            'order': 1,
            'required': false,
            'validationRegex': '',
            'mask': '2',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'valor_aprovado_r',
            'type': 'Double',
            'label': 'Valor Aprovado (R$)',
            'size': '100%',
            'order': 2,
            'required': false,
            'validationRegex': '',
            'mask': '2',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'observacao',
            'type': 'String',
            'label': 'Observacao',
            'size': '100%',
            'order': 3,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo01',
            'type': 'String',
            'label': 'CAMPO01',
            'size': '50%',
            'order': 4,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo02',
            'type': 'String',
            'label': 'CAMPO02',
            'size': '50%',
            'order': 5,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo03',
            'type': 'String',
            'label': 'CAMPO03',
            'size': '50%',
            'order': 6,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo04',
            'type': 'String',
            'label': 'CAMPO04',
            'size': '100%',
            'order': 7,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo05',
            'type': 'String',
            'label': 'CAMPO05',
            'size': '50%',
            'order': 8,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo06',
            'type': 'String',
            'label': 'CAMPO06',
            'size': '50%',
            'order': 9,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo07',
            'type': 'String',
            'label': 'CAMPO07',
            'size': '50%',
            'order': 10,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo08',
            'type': 'String',
            'label': 'CAMPO08',
            'size': '50%',
            'order': 11,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo09',
            'type': 'String',
            'label': 'CAMPO09',
            'size': '50%',
            'order': 12,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo10',
            'type': 'String',
            'label': 'CAMPO10',
            'size': '50%',
            'order': 13,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo11',
            'type': 'String',
            'label': 'CAMPO11',
            'size': '50%',
            'order': 14,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo12',
            'type': 'String',
            'label': 'CAMPO12',
            'size': '50%',
            'order': 15,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo13',
            'type': 'String',
            'label': 'CAMPO13',
            'size': '50%',
            'order': 16,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo14',
            'type': 'String',
            'label': 'CAMPO14',
            'size': '50%',
            'order': 17,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
        {
            'name': 'campo15',
            'type': 'String',
            'label': 'CAMPO15',
            'size': '50%',
            'order': 18,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
{
            'name': 'campo16',
            'type': 'String',
            'label': 'CAMPO15',
            'size': '50%',
            'order': 18,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
{
            'name': 'campo17',
            'type': 'String',
            'label': 'CAMPO15',
            'size': '50%',
            'order': 18,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        },
{
            'name': 'campo18',
            'type': 'String',
            'label': 'CAMPO15',
            'size': '50%',
            'order': 18,
            'required': false,
            'validationRegex': '',
            'mask': '',
            'appWorkflow': true,
            'isBreakLine': false
        }
    ]
}";


            var tableJson = JsonConvert.DeserializeObject<Formulario>(json);


            var schemaProvider = context.DataProvider.GetSchemaProvider();

            var schema = schemaProvider.GetSchema(context, new GetSchemaOptions());

            var tableScheme = schema.Tables.Where(c => c.TableName == tableJson.Name).FirstOrDefault();

            if (tableScheme == null)
            {
                TableClass tableClass = new TableClass(tableJson.Name, tableJson.Fields);
                var createTable = tableClass.CreateTableScript();
                context.Execute(createTable);
            }
            else
            {
                List<Campos> camposNovos = new List<Campos>();
                foreach (var field in tableJson.Fields)
                {
                    if(!tableScheme.Columns.Where(c => c.ColumnName == field.Name).Any())
                    {
                        camposNovos.Add(field);
                    }
                }

                if (camposNovos.Count > 0)
                {
                    var AltersTable = new AlterTable(tableJson.Name, camposNovos).AlterTableScript();
                    context.Execute(AltersTable);
                }
            }


        }
    }

    public class AlterTable
    {
        private List<KeyValuePair<String, String>> _fieldInfo = new List<KeyValuePair<String, String>>();
        private string _className = String.Empty;

        private Dictionary<String, String> dataMapper
        {
            get
            {
                // Add the rest of your CLR Types to SQL Types mapping here
                Dictionary<String, String> dataMapper = new Dictionary<string, string>();
                dataMapper.Add("Integer", "BIGINT");
                dataMapper.Add("String", "varchar(500)");
                dataMapper.Add("Double", "FLOAT");

                return dataMapper;
            }
        }

        public List<KeyValuePair<String, String>> Fields
        {
            get { return this._fieldInfo; }
            set { this._fieldInfo = value; }
        }

        public string ClassName
        {
            get { return this._className; }
            set { this._className = value; }
        }

        public AlterTable(string tableName, List<Campos> campos)
        {
            this._className = tableName;

            foreach (var campo in campos)
            {
                KeyValuePair<String, String> field = new KeyValuePair<String, String>(campo.Name, campo.Type);

                this.Fields.Add(field);
            }
        }

        public string AlterTableScript()
        {
            System.Text.StringBuilder script = new StringBuilder();
            for (int i = 0; i < this.Fields.Count; i++)
            {
                KeyValuePair<String, String> field = this.Fields[i];

                if (dataMapper.ContainsKey(field.Value))
                {
                    script.Append($"\t ALTER TABLE {this.ClassName} ADD COLUMN {field.Key} {dataMapper[field.Value]};\n");
                }


                script.Append(Environment.NewLine);
            }
            return script.ToString();
        }
    }

    public class TableClass
    {
        private List<KeyValuePair<String, String>> _fieldInfo = new List<KeyValuePair<String, String>>();
        private string _className = String.Empty;

        private Dictionary<String, String> dataMapper
        {
            get
            {
                // Add the rest of your CLR Types to SQL Types mapping here
                Dictionary<String, String> dataMapper = new Dictionary<string, string>();
                dataMapper.Add("Integer", "BIGINT");
                dataMapper.Add("String", "varchar(500)");
                dataMapper.Add("Double", "FLOAT");

                return dataMapper;
            }
        }

        public List<KeyValuePair<String, String>> Fields
        {
            get { return this._fieldInfo; }
            set { this._fieldInfo = value; }
        }

        public string ClassName
        {
            get { return this._className; }
            set { this._className = value; }
        }

        public TableClass(string tableName, List<Campos> campos)
        {
            this._className = tableName;

            foreach (var campo in campos)
            {
                KeyValuePair<String, String> field = new KeyValuePair<String, String>(campo.Name, campo.Type);

                this.Fields.Add(field);
            }
        }

        public string CreateTableScript()
        {

            System.Text.StringBuilder script = new StringBuilder();
            script.AppendLine("CREATE TABLE " + this.ClassName);
            script.AppendLine("(");
            for (int i = 0; i < this.Fields.Count; i++)
            {
                KeyValuePair<String, String> field = this.Fields[i];

                if (dataMapper.ContainsKey(field.Value))
                {
                    script.Append("\t " + field.Key + " " + dataMapper[field.Value]);
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

