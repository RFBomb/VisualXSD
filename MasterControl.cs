using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace XSD_Tool_Helper
{
    public interface IMasterControl
    {
        public string NameSpace { get; }
        public string OutputFileName { get; }
        public bool ParamFileContainsFilePaths { get; }
        public bool GenerateParamFile { get; }
        public bool ProcessIndividually { get; }
        public DirectoryInfo OutputFolder { get; }
        public List<FileInfo> InputFileList { get; }
        
        /// <summary>
        /// Generate the commands for this setup
        /// </summary>
        /// <returns>Returns a string[] object. Each command to be run has 1 object representing the arguments .</returns>
        public string[] GenerateCommand();
        public void Run();
    }
}
