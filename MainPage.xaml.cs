using LABChromaAI.App.Templates.Home.UI;
using LABChromaAI.App.Translations;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace LABChromaAI.App
{
    public partial class MainPage : ContentPage
    {
        private static TranslateLibrary Translate = new TranslateLibrary();

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadPage();
        }

        private void LoadPage()
        {
            LoadLabels();
        }

        #region #Label.Text
        private void LoadLabels()
        {
            LBL_Welcome.Text = GetTranslatedTag("TAG_Welcome") + "!";
            ENTRY_User.Placeholder = GetTranslatedTag("TAG_User");
            ENTRY_Password.Placeholder = GetTranslatedTag("TAG_Password");
            BTN_Login.Text = GetTranslatedTag("TAG_Login");
            LBL_Help.Text = GetTranslatedTag("TAG_Help") + " 💬";
        }
        #endregion

        #region #Get
        private string GetTranslatedTag(string TagKey)
        {
           return Translate.GetTranslatedTag(TagKey);
        }
        #endregion

        #region #OnClick
        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // 1. Obter nome de usuário e senha dos campos de entrada
            //string username = UsernameEntry.Text;
            //string password = PasswordEntry.Text;

            Navigation.PushAsync(new HomePage());

            // 2. Validar as credenciais (chamando um serviço de autenticação, se necessário)
            /*
            if (ValidaLogin(username, password))
            {
                // 3. Se as credenciais forem válidas, navegue para a HomePage
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                // 4. Exibir uma mensagem de erro (se as credenciais forem inválidas)
                await DisplayAlert("Erro", "Usuário ou senha inválidos", "OK");
            }*/
        }
        #endregion
    }
}
