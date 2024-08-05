using System;

namespace LABChromaAI.App.Templates.Chroma.UI
{
    public partial class ChromaPage : ContentPage
    {
        private static List<ToolbarItem> originalToolbarItems = new List<ToolbarItem>();

        public ChromaPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            NavigationPage.SetHasBackButton(this, true);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ToolbarItems.Clear();
        }

        private void OnCameraClicked(object sender, EventArgs e)
        {

        }
    }
}
