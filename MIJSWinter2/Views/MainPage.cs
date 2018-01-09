using System;

using Xamarin.Forms;

namespace MIJSWinter2
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page aboutPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    aboutPage = new NavigationPage(new AboutPage())
                    {
                        Title = "カメラ撮影"
                    };
                    aboutPage.Icon = "tab_about.png";
                    break;
                default:
                    aboutPage = new AboutPage()
                    {
                        Title = "About"
                    };
                    break;
            }

            Children.Add(aboutPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
