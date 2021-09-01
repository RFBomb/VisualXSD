using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace XSD_Tool_Helper
{
    public static class StaticMethods
    {
        static StaticMethods() 
        {
            XSD_Path = FindXSD();
        }

        public static string XSD_Path { get; private set; }
        private static string ProgFiles => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        private static string ProgFilesX86 => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
        private const string SubDir_1 = "\\Microsoft SDKs\\Windows\\";

        /// <summary>
        /// return the first instance of XSD.exe found
        /// </summary>
        /// <returns></returns>
        private static string FindXSD()
        {
            //C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\XSD.exe
            //C:\Program Files(x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\x64\XSD.exe

            DirectoryInfo Test = new DirectoryInfo(Path.Combine(ProgFilesX86 + SubDir_1));
            bool SearchAgain = false;
            Search:
            SearchAgain = !SearchAgain;
            DirectoryInfo[] Dirs = Test.GetDirectories();
            foreach (DirectoryInfo unknownDir in Dirs) // Checking the windows versions folders
            {
                DirectoryInfo bin = unknownDir?.GetDirectories()?.Single(binFolder => binFolder.Name == "bin");
                if (bin != null) // Checking within the bin folders
                {
                    foreach (DirectoryInfo dir in bin.GetDirectories("NETFX*Tools"))
                    {
                        foreach (FileInfo f in dir.GetFiles("XSD.exe"))
                            return f.FullName;
                        foreach (DirectoryInfo subdir in dir.GetDirectories("\x64"))
                            foreach (FileInfo f in dir.GetFiles("XSD.exe"))
                                return f.FullName;
                    }
                }
            }
            if (SearchAgain)
            {
                Test = new DirectoryInfo(Path.Combine(ProgFiles + SubDir_1));
                goto Search;
            }
            return "";
        }

        /// <summary>
        /// Validate the NameSpace textbox
        /// </summary>
        /// <param name="NameSpace">Textbox.Text</param>
        /// <param name="ValidatedNameSpace">Return the Validated NameSpace string on this variable. </param>
        /// <returns>Returns true if a valid NameSpace string has been entered. If the string is invalid, return false.</returns>
        public static bool ValidateNameSpace(string NameSpace, out string ValidatedNameSpace)
        {
            ValidatedNameSpace = "";
            if (String.IsNullOrWhiteSpace(NameSpace)) return true;  // This is fine, no data to validate. 
            Regex regex = new Regex("[^\\w\\.\\s_:]"); //use regex to ensure that all characters are either letters, periods, or underscores.
            bool res = regex.Match(NameSpace).Success;
            if (res)
            {
                MessageBox.Show($"Invalid Characters Found in NameSpace! {Environment.NewLine} Please ensure that all characters are letters, underscores, or periods.", "Invalid NameSpace");
                return false;
            }
            ValidatedNameSpace = NameSpace.Trim();
            if (ValidatedNameSpace.Contains(" "))
            {
                DialogResult ask = MessageBox.Show("The NameSpace contains spaces, which are not allowed. Replace with underscores?", "Spaces Fonud - Replace?", MessageBoxButtons.YesNo);
                if (ask == DialogResult.Yes)
                {
                    ValidatedNameSpace = ValidatedNameSpace.Replace(" ", "_");
                    return true;
                }
                else
                    return false;
            }
            return true;
        }

        public static List<FileInfo> FilePicker_XML => FilePicker(new string[] { "*.XML" } );
        public static List<FileInfo> FilePicker_XDR => FilePicker(new string[] { "*.XDR" });
        public static List<FileInfo> FilePicker_XSD => FilePicker(new string[] { "*.XSD" } );
        public static List<FileInfo> FilePicker_Assy => FilePicker(new string[] { "*.DLL", "*.Exe" });

        private static List<FileInfo> FilePicker(string[] FileExtensions) 
        {
            List<FileInfo> ret = new List<FileInfo>();
            OpenFileDialog FilePicker = new OpenFileDialog();
            FilePicker.Title = "Select a file to open";
            FilePicker.AddExtension = false;
            FilePicker.Multiselect = true;
            FilePicker.DefaultExt = FileExtensions[0];
            string ext = "";
            foreach (string s in FileExtensions)
                ext += $"{s}|";
            FilePicker.Filter = ext;
            FilePicker.ShowDialog();
            string[] returnNames = FilePicker?.FileNames;
            if (returnNames != null)
                foreach (string f in returnNames)
                    ret.Add(new FileInfo(f));
            return ret;
        }


        public static List<FileInfo> FolderImport_XML => FolderImport(new string[] { "*.XML" });
        public static List<FileInfo> FolderImport_XDR => FolderImport(new string[] { "*.XDR" });
        public static List<FileInfo> FolderImport_XSD => FolderImport(new string[] { "*.XSD" });
        public static List<FileInfo> FolderImport_Assy => FolderImport(new string[] { "*.DLL", "*.Exe" });
        private static List<FileInfo> FolderImport(string[] FileExtension)
        {
            List<FileInfo> ret = new List<FileInfo>();
            return ret;
        }

        public static DirectoryInfo FolderPicker(string Descrip = "Select Destination Folder", DirectoryInfo StartPath = null)
        {
            DirectoryInfo ret = null;
            FolderBrowserDialog browser = new FolderBrowserDialog();
            browser.SelectedPath = StartPath?.FullName;
            browser.ShowNewFolderButton = true;
            browser.UseDescriptionForTitle = true;
            browser.Description = Descrip;
            DialogResult ask = browser.ShowDialog();
            if (ask == DialogResult.OK)
                ret = new DirectoryInfo(browser.SelectedPath);
            return ret;
        }
    }
}
