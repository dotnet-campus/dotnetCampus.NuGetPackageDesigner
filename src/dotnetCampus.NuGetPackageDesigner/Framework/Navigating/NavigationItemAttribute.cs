using System;

namespace dotnetCampus.NuGetPackageDesigner.Framework.Navigating
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class NavigationItemAttribute : Attribute
    {
        public string Title { get; }

        public NavigationItemAttribute(string title)
        {
            Title = title;
        }
    }
}
