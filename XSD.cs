using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSD_Tool_Helper
{
    public class XSD
    {
        /// <summary>
        /// This enum is for all supported language types
        /// </summary>
        public enum SupportedLanguages { CS, VB, JS, VJS }

        /// <summary>
        /// Converts the SupportedLanguages enum to the appropriate string
        /// </summary>
        public static string LanguageEnumToString(SupportedLanguages Language)
        {
            switch (Language)
            {
                case SupportedLanguages.CS: return "CS";
                case SupportedLanguages.VB: return "VB";
                case SupportedLanguages.JS: return "JS";
                case SupportedLanguages.VJS: return "VJS";
                default: return "CS";
            }
        }

        /// <summary>
        /// Converts the SupportedLanguages enum to the appropriate string
        /// </summary>
        public static SupportedLanguages LangaugeCmbToEnum(int ListIndex)
        {
            return ListIndex switch
            {
                0 => SupportedLanguages.CS,
                1 => SupportedLanguages.VB,
                2 => SupportedLanguages.JS,
                3 => SupportedLanguages.VJS,
                _ => SupportedLanguages.CS,
            };
        }

        /// <summary> Method to check if a path needs to be wrapped in quotes</summary>
        /// <returns> 
        /// If the path has a space in it and does not start with a quotation mark, it will wrap the input string in quotations and return the new string. 
        /// <br/> If the path does not require wrapping, return the input string.
        /// </returns>
        public static string WrapPath(string PathString) => PathString.Contains(" ") && !PathString.StartsWith('\"') ? '\"' + PathString + '\"' : PathString;

        /// <summary>
        /// This is the list to display in the Language Selector ComboBox
        /// </summary>
        public static readonly List<string> SupportedLanguages_ComboxItems = new List<string> { "C#", "Visual Basic", "JavaSript", "Visual J#" };

        public const string INFILE = " {0} ";
        public const string OUTFOLDER = " -outputdir:{0}";
        public const string PARAMETERS = " /parameters:{0}"; // Must point to some ParameterFile.xml

        /// <summary> </summary>
        public List<FileInfo> InputFilePaths { get; } = new List<FileInfo>();
        
        /// <summary> </summary>
        public string OutputDirectory { get; set;} = "";
        
        /// <summary> </summary>
        public bool GenerateParameterFile { get; set; } = false;
        
        /// <summary> </summary>
        public string ParameterFilePath { get; set; } = "";
        
        /// <summary> </summary>
        public bool ParameterFileContainsInputFiles { get; set; } = false;

        /// <summary> </summary>
        /// <returns>Returns the string of ARGUMENTS ready to be passed into a Process object. </returns>
        public virtual string GenerateCommand()
        {
            string result = "";
            bool addInputFiles = true;

            if (this.GenerateParameterFile | !String.IsNullOrWhiteSpace(this.ParameterFilePath) )
            {
                addInputFiles = !this.ParameterFileContainsInputFiles;
                result += String.Format(PARAMETERS, WrapPath(this.ParameterFilePath));
            }

            if (addInputFiles)
                foreach (FileInfo file in InputFilePaths)
                {
                    file.Refresh();
                    if (file.Exists)
                        result += String.Format(INFILE, WrapPath(file.FullName));
                }

            if (!String.IsNullOrWhiteSpace(OutputDirectory))
                result += String.Format(OUTFOLDER, WrapPath(OutputDirectory));

            return result;
        }

        public virtual void GenerateParamFile() 
        { 

        }

        /// <summary>
        /// Generate a new command and run it
        /// </summary>
        public void Run()
        {
            string cmd = GenerateCommand();
            Console.WriteLine(cmd);
            if (cmd != "")
                return;
        }

    }
}
