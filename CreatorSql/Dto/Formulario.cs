using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatorSql.Dto
{
    public class Formulario
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public bool Internal { get; set; }
        public List<Campos> Fields { get; set; }
    }
}
