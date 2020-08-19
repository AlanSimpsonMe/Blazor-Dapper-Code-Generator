using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDapperCodeGen.Data
{
    public class Tablefield
    {
        // Auto-implemented properties.
        public string Fieldname { get; set; }
        public string SQLtype { get; set; }
        public string Codetype { get; set; }
        public string DBtype { get; set; }
        public int Length { get; set; }
        public bool IsRequired { get; set; }
        
        public Tablefield()
        {

        }

        public Tablefield(string fieldname, string sqlytpe, string codetype, string dbtype, int length, bool isrequired)
        {
            this.Fieldname = fieldname;
            this.SQLtype = sqlytpe;
            this.Codetype = codetype;
            this.DBtype = dbtype;
            this.Length = length;
            this.IsRequired = isrequired;
        }
    }
}
