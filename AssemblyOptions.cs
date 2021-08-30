using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSD_Tool_Helper
{
    class AssemblyOptions : XSD
    {
        private const string ASSEMBLY_OPTION_TYPE = "/type:{0}";

        /// <summary>
        /// List of <paramref name = "typeNames"/> within an assembly to create a schema for. 
        /// <br/>If <paramref name = "typeName"/> does not specify a nameSpace, XSD matches all types in the assembly with the specified type. 
        /// <br/>If <paramref name = "typeName"/> specified a namespace, only that type is matched. 
        /// <br/>If <paramref name = "typeName"/> ends with an asterisk, the tool matches all types that start with the string preceeding the asterisk.
        /// <br/>If this list is empty, then the tool will generate schemas for all types found in the assembly. 
        /// </summary>
        public List<string> TypeNames { get; } = new List<string>();

        public override string GenerateCommand()
        {
            string result = base.GenerateCommand();
            foreach (string tn in TypeNames)
                result += String.IsNullOrWhiteSpace(tn) ? "" : String.Format(ASSEMBLY_OPTION_TYPE, tn);

            return result;
        }

        public override void GenerateParamFile()
        {

        }
    }
}
