using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatorSql.Dto
{
    public class Campos
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Label { get; set; }
        public string Size { get; set; }
        public int Order { get; set; }
        public bool Required { get; set; }
        public string ValidationRegex { get; set; }
        public string Mask { get; set; }
        public bool AppWorkflow { get; set; }
        public bool IsBreakLine { get; set; }
    }
}
