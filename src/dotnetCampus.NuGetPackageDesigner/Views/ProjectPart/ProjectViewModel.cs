using System.IO;
using dotnetCampus.NuGetPackageDesigner.Framework;

namespace dotnetCampus.NuGetPackageDesigner.Views.Main
{
    public class PackageViewModel : BindableObject
    {
        private string _projectFile;
        private string _projectFolder;
        private string _projectName;

        public PackageViewModel()
        {
        }

        public string ProjectFile
        {
            get => _projectFile;
            set
            {
                SetValue(ref _projectFile, value);
                ProjectFolder = Path.GetDirectoryName(_projectFile);
            }
        }

        public string ProjectFolder
        {
            get => _projectFolder;
            private set => SetValue(ref _projectFolder, value);
        }

        public string ProjectName
        {
            get => _projectName;
            private set => SetValue(ref _projectName, value);
        }
    }
}
