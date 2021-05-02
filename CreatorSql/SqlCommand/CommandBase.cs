using CreatorSql.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatorSql.SqlCommand
{
    public abstract class CommandBase
    {
        protected List<KeyValuePair<String, object>> _fieldInfo = new List<KeyValuePair<String, object>>();
        protected string _className = String.Empty;

        protected Dictionary<String, object> dataMapper
        {
            get
            {
                // Add the rest of your CLR Types to SQL Types mapping here
                Dictionary<String, object> dataMapper = new Dictionary<string, object>();
                dataMapper.Add("Integer", "BIGINT");
                dataMapper.Add("String", "varchar(500)");
                dataMapper.Add("Double", "FLOAT");

                return dataMapper;
            }
        }

        protected List<KeyValuePair<String, object>> Fields
        {
            get { return this._fieldInfo; }
            set { this._fieldInfo = value; }
        }

        protected string ClassName
        {
            get { return this._className; }
            set { this._className = value; }
        }

        public abstract string GenerateScript();
    }
}
