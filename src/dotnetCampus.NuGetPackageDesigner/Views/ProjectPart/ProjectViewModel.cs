using System.IO;
using dotnetCampus.NuGetPackageDesigner.Framework;

namespace dotnetCampus.NuGetPackageDesigner.Views.Main
{
    public class ProjectViewModel : BindableObject
    {
        private string _projectPath;
        private string _projectFolder;
        private string _projectName;

        public ProjectViewModel()
        {
            ProjectPath = @"D:\Developments\Open\dotnetCampus.NuGetPackageDesigner\src\dotnetCampus.NuGetPackageDesigner\dotnetCampus.NuGetPackageDesigner.csproj";
        }

        public string ProjectPath
        {
            get => _projectPath;
            set
            {
                SetValue(ref _projectPath, value);
                ProjectFolder = Path.GetDirectoryName(_projectPath);
                ProjectName = Path.GetFileNameWithoutExtension(_projectPath);
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
