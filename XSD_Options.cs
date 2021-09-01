using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSD_Tool_Helper
{
    public class XSD_Options : XSD
    {
        public XSD_Options() { WhatToGenerate = Generate.NOTHING; }
        public XSD_Options(Generate whatToGenerate) { this.WhatToGenerate = whatToGenerate; }


        public enum Generate { NOTHING, CLASSES, DATASET }
        private const string GENERATE_CLASSES = " /classes";
        private const string GENERATE_DATASET = " /dataset";
        //private const string OUTFOLDER = " /out:{0}"; // DO NOT USE -> Use OUTFOLDER instead
        private const string LANGUAGE = " /language:\"{0}\"";
        private const string NAMESPACE = " /namespace:\"{0}\"";

        private const string OPT_ELEMENT = " /element\"{0}\"";
        private const string OPT_URI = " /uri:\"{0}\"";

        //Bool Options
        private const string OPT_ENABLEDATABINDING = " /enableDataBinding";
        private const string OPT_ENABLELINQDATASET = " /enableLinqDataSet";
        private const string OPT_FIELDS = " /fields";
        private const string OPT_SUPPRESSBANNER = " /nologo";
        private const string OPT_ORDER = " /order";

        /// <summary> </summary>
        public Generate WhatToGenerate { get; set; }

        /// <summary> Specify the output programming language. Default is C# (C-Sharp)</summary>
        public XSD.SupportedLanguages Language { get; set; } = XSD.SupportedLanguages.CS;

        /// <summary> Specify the runtime namespace for the generate types. If not set, the default namespace is "Schemas" </summary>
        public string NameSpace { get; set; } = "";

        /// <summary> Contains a list of all elements in the schema to generate code for. If this is an empty list, all elements will be typed. </summary>
        public List<string> ElementList { get; } = new List<string>();

        /// <summary> Specify the URI for the elements in the schema to generate code for. This URI, if present, applies to all elements specified within the <paramref name="ElementList"/></summary>
        public string URI { get; set; } = "";

        /// <summary> If TRUE, implements the INotifiyPropertyChanged interface on all generated types to enable data binding. </summary>
        public bool EnableDataBinding { get; set; } = false;

        /// <summary> 
        /// Specify that the generated DataSet can be quieried against using LINQ-to-DataSet. 
        /// This option is autoamtically used when generated a DataSet.
        /// </summary>
        public bool EnableLinqDataSet { get; set; } = false;

        /// <summary> Generate Field values instead of Property values for the output class(es) </summary>  
        public bool GenerateFieldsInsteadOfProperties { get; set; } = false;

        /// <summary> Toggles the 'NoLogo' option </summary>
        public bool SuppressBanner { get; set; } = false;

        /// <summary> If TRUE: Generate explicit order identifiers on all particle members. </summary>
        public bool Order { get; set; } = false;


        /// <summary>
        /// Compiles the currently set up options and formats it to return a string to be appended onto the command line.
        /// </summary>
        public override string GenerateCommand()
        {
            string result = base.GenerateCommand();
            if (this.WhatToGenerate == Generate.NOTHING) return result;

            result += (WhatToGenerate == Generate.CLASSES) ? GENERATE_CLASSES : GENERATE_DATASET;
            result += String.Format(LANGUAGE, XSD.LanguageEnumToString(this.Language));
            result += EnableDataBinding ? OPT_ENABLEDATABINDING : "";
            result += EnableLinqDataSet ? OPT_ENABLELINQDATASET : "";
            result += SuppressBanner ? OPT_SUPPRESSBANNER : "";
            result += Order ? OPT_ORDER : "";
            result += GenerateFieldsInsteadOfProperties ? OPT_FIELDS : "";
            result += String.IsNullOrWhiteSpace(NameSpace) ? "" : String.Format(NAMESPACE, NameSpace);
            result += String.IsNullOrWhiteSpace(URI) ? "" : String.Format(OPT_URI, URI);
            foreach (string el in ElementList)
                result += String.IsNullOrWhiteSpace(el) ? "" : String.Format(OPT_ELEMENT, el);

            return result;
        }

        public override void GenerateParamFile()
        {
        }

    }
}
