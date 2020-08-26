using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDapperCodeGen.Data
{
    public class Codetemplate
    {
        public string NamespaceName { get; set; }
        public string TableDesign { get; set; }
        public string ClassName { get; set; }
        public string ObjectName { get; set; }
        public string ObjectList { get; set; }
        public string RawTemplate { get; set; }
        public string GeneratedCode { get; set; }        
    }
}
