using CreatorSql.Context;
using CreatorSql.Dto;
using CreatorSql.SqlCommand;
using LinqToDB.Data;
using LinqToDB.SchemaProvider;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatorSql.Service
{
    public class FormularioService
    {

        public bool CriarOuAlteraFormularioTable()
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

            var comandoRealizadoComSucesso = true;
            if (tableScheme == null)
            {
                TableClass tableClass = new TableClass(tableJson.Name, tableJson.Fields);
                var createTable = tableClass.GenerateScript();
                comandoRealizadoComSucesso = context.Execute(createTable) > 0;
            }
            else
            {
                List<Campos> camposNovos = new List<Campos>();
                foreach (var field in tableJson.Fields)
                {
                    if (!tableScheme.Columns.Where(c => c.ColumnName == field.Name).Any())
                    {
                        camposNovos.Add(field);
                    }
                }

                if (camposNovos.Count > 0)
                {
                    var AltersTable = new AlterTable(tableJson.Name, camposNovos).GenerateScript();
                    comandoRealizadoComSucesso = context.Execute(AltersTable) > 0;
                }
            }

            return comandoRealizadoComSucesso;
        }

        public bool SalvaConteudoFormulario()
        {
            var context = new MainContext();
            var comandoRealizadoComSucesso = true;

            var json = @"{
'@odata.context': '$metadata#decisionpadrao',
    'value': [
        {
            'id': 1,
            'processInstanceId': 73,
            'nf': 1233,
            'valor_solicitado_r': 25212.55,
            'valor_aprovado_r': null,
            'observacao': '22222',
            'campo01': null,
            'campo02': null,
            'campo03': null,
            'campo04': null,
            'campo05': null,
            'campo06': null,
            'campo07': null,
            'campo08': null,
            'campo09': null,
            'campo10': null,
            'campo11': null,
            'campo12': null,
            'campo13': null,
            'campo14': null,
            'campo15': null
        },
        {
            'id': 2,
            'processInstanceId': 75,
            'nf': 1233,
            'valor_solicitado_r': 111421.11,
            'valor_aprovado_r': null,
            'observacao': 'jkhjkhkjhkjhk',
            'campo01': null,
            'campo02': null,
            'campo03': null,
            'campo04': null,
            'campo05': null,
            'campo06': null,
            'campo07': null,
            'campo08': null,
            'campo09': null,
            'campo10': null,
            'campo11': null,
            'campo12': null,
            'campo13': null,
            'campo14': null,
            'campo15': null
        },
        {
            'id': 3,
            'processInstanceId': 79,
            'nf': 111111,
            'valor_solicitado_r': 10000,
            'valor_aprovado_r': 1.11,
            'observacao': 'teste Ederson',
            'campo01': null,
            'campo02': null,
            'campo03': null,
            'campo04': null,
            'campo05': null,
            'campo06': null,
            'campo07': null,
            'campo08': null,
            'campo09': null,
            'campo10': null,
            'campo11': null,
            'campo12': null,
            'campo13': null,
            'campo14': null,
            'campo15': null
        },
        {
            'id': 4,
            'processInstanceId': 84,
            'nf': 1233,
            'valor_solicitado_r': 21215.45,
            'valor_aprovado_r': null,
            'observacao': '12121231',
            'campo01': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo02': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo03': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo04': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo05': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo06': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo07': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo08': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo09': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo10': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo11': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo12': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo13': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo14': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo15': 'UMa Nova CHANCE - GRANDES Oportunidades'
        },
        {
            'id': 5,
            'processInstanceId': 102,
            'nf': 0,
            'valor_solicitado_r': 1.11,
            'valor_aprovado_r': null,
            'observacao': 'dasd',
            'campo01': null,
            'campo02': null,
            'campo03': null,
            'campo04': null,
            'campo05': null,
            'campo06': null,
            'campo07': null,
            'campo08': null,
            'campo09': null,
            'campo10': null,
            'campo11': null,
            'campo12': null,
            'campo13': null,
            'campo14': null,
            'campo15': null
        },
        {
            'id': 6,
            'processInstanceId': 200,
            'nf': 1233,
            'valor_solicitado_r': 21215.45,
            'valor_aprovado_r': null,
            'observacao': '22222',
            'campo01': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo02': '1121',
            'campo03': '1212',
            'campo04': '12121',
            'campo05': null,
            'campo06': null,
            'campo07': null,
            'campo08': null,
            'campo09': null,
            'campo10': null,
            'campo11': null,
            'campo12': null,
            'campo13': null,
            'campo14': null,
            'campo15': null
        },
        {
            'id': 7,
            'processInstanceId': 203,
            'nf': 1233,
            'valor_solicitado_r': 21215.45,
            'valor_aprovado_r': 30000,
            'observacao': '22222',
            'campo01': 'UMa Nova CHANCE - GRANDES Oportunidades',
            'campo02': '1121',
            'campo03': null,
            'campo04': '12121',
            'campo05': '112454',
            'campo06': null,
            'campo07': null,
            'campo08': null,
            'campo09': '5454',
            'campo10': null,
            'campo11': '45645',
            'campo12': null,
            'campo13': null,
            'campo14': null,
            'campo15': null
        }
    ]
}";
            var dictionario = deserializeToDictionary(json);

            var insertScript = new Insert("decisionpadrao", dictionario);

            var scriptInsert = insertScript.GenerateScript();

            context.Execute(scriptInsert);

            return comandoRealizadoComSucesso;
        }

        private object deserializeToDictionary(string jo, bool isArray = false)
        {
            if (!isArray)
            {
                isArray = jo.Substring(0, 1) == "[";
            }
            if (!isArray)
            {
                var values = JsonConvert.DeserializeObject<Dictionary<string, object>>(jo);
                var values2 = new Dictionary<string, object>();
                foreach (KeyValuePair<string, object> d in values)
                {
                    if (d.Value is JObject)
                    {
                        values2.Add(d.Key, deserializeToDictionary(d.Value.ToString()));
                    }
                    else if (d.Value is JArray)
                    {
                        values2.Add(d.Key, deserializeToDictionary(d.Value.ToString(), true));
                    }
                    else
                    {
                        values2.Add(d.Key, d.Value);
                    }
                }
                return values2;
            }
            else
            {
                var values = JsonConvert.DeserializeObject<List<object>>(jo);
                var values2 = new List<object>();
                foreach (var d in values)
                {
                    if (d is JObject)
                    {
                        values2.Add(deserializeToDictionary(d.ToString()));
                    }
                    else if (d is JArray)
                    {
                        values2.Add(deserializeToDictionary(d.ToString(), true));
                    }
                    else
                    {
                        values2.Add(d);
                    }
                }
                return values2;
            }
        }
    }
}
