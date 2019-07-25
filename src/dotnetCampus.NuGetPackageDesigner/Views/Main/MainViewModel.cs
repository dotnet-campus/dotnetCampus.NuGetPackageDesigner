using System.Collections.ObjectModel;
using dotnetCampus.NuGetPackageDesigner.Framework;
using dotnetCampus.NuGetPackageDesigner.Framework.Navigating;
using dotnetCampus.NuGetPackageDesigner.Views.ProjectPart;

namespace dotnetCampus.NuGetPackageDesigner.Views.Main
{
    public class MainViewModel : BindableObject
    {
        public ObservableCollection<NavigationItem> PageItems { get; } = new ObservableCollection<NavigationItem>
        {
            NavigationItem.Combine<ProjectPage, ProjectViewModel>("项目"),
        };
    }
}
