using CreatorSql.Context;
using CreatorSql.Dto;
using CreatorSql.SqlCommand;
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
using CreatorSql.Service;

namespace CreatorSql
{
    class Program
    {
        static void Main(string[] args)
        {

            var FormularioService = new FormularioService();

            FormularioService.SalvaConteudoFormulario();


        }
    }


}

