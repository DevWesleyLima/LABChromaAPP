using LABChromaAI.App.Templates.Chroma.UI;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Platform;
using System;
using System.Collections;

namespace LABChromaAI.App.Templates.Home.UI
{
    public partial class HomePage : ContentPage
    {       
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
        }

        public INavigation GetNavigation()
        {
            return Navigation;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //LoadPage();
        }
       
        private void LoadPage()
        {

        }

        private void OnAIChatClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChatPage());
        }

        private void OnAICamClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChromaPage());
        }

        private void OnMenuClicked(object sender, EventArgs e)
        {
            SECONDARYMENU_HOME.IsVisible = !SECONDARYMENU_HOME.IsVisible;

            if(SECONDARYMENU_HOME.IsVisible == true)
            {
                BTNMENU_HOME.Source = "Media/Icons/menuchromaopened_transparent.png";
            }
            else
            {
                BTNMENU_HOME.Source = "Media/Icons/menuchroma_transparent.png";
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
