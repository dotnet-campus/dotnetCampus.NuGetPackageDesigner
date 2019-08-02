using System.Collections.ObjectModel;
using dotnetCampus.NuGetPackageDesigner.Views.AdvancePart;
using dotnetCampus.NuGetPackageDesigner.Views.CodePart;
using dotnetCampus.NuGetPackageDesigner.Views.CommandPart;
using dotnetCampus.NuGetPackageDesigner.Views.FilePart;
using dotnetCampus.NuGetPackageDesigner.Views.OutputPart;
using dotnetCampus.NuGetPackageDesigner.Views.PackagePart;
using dotnetCampus.NuGetPackageDesigner.Views.ProjectPart;
using Walterlv.ComponentModel;
using Walterlv.Windows.Navigating;

namespace dotnetCampus.NuGetPackageDesigner.Views.Main
{
    public class MainViewModel : BindableObject
    {
        public ObservableCollection<NavigationItem> PageItems { get; } = new ObservableCollection<NavigationItem>
        {
            NavigationItem.Combine<ProjectPage, ProjectViewModel>("项目"),
            NavigationItem.Combine<PackagePage, PackageViewModel>("包信息"),
            NavigationItem.Combine<OutputPage, OutputViewModel>("项目输出"),
            NavigationItem.Combine<FilePage, FileViewModel>("引入文件"),
            NavigationItem.Combine<CodePage, CodeViewModel>("引入源码"),
            NavigationItem.Combine<CommandPage, CommandViewModel>("命令"),
            NavigationItem.Combine<AdvancePage, AdvanceViewModel>("高级"),
        };
    }
}
