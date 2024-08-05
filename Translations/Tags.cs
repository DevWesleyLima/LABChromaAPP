using System;

namespace LABChromaAI.App.Translations
{
    public class Tags(string Language)
    {
        public List<(string Tag, string Value)> GetListAllTranslatedTags()
        {
            return new List<(string Tag, string Value)>
            {
                #region #List.Add
                    #region #A
                    #endregion

                    #region #B
                    #endregion

                    #region #C
                    (TAG_Calculator(true), TAG_Calculator(false)),
                    #endregion

                    #region #D
                    #endregion

                    #region #E
                    #endregion

                    #region #F
                    #endregion

                    #region #G
                    #endregion

                    #region #H
                    (TAG_Help(true), TAG_Help(false)),
                    #endregion

                    #region #I
                    #endregion

                    #region #J
                    #endregion

                    #region #K
                    #endregion

                    #region #L
                    (TAG_Logo(true), TAG_Logo(false)),
                    (TAG_Login(true), TAG_Login(false)),
                    #endregion

                    #region #M
                    #endregion

                    #region #N
                    #endregion

                    #region #O
                    #endregion

                    #region #P                
                    (TAG_Password(true), TAG_Password(false)),
                    #endregion

                    #region #Q
                    #endregion

                    #region #R
                    #endregion

                    #region #S
                    #endregion

                    #region #T
                    #endregion

                    #region #U                
                    (TAG_User(true), TAG_User(false)),
                    #endregion

                    #region #V
                    #endregion

                    #region #X
                    #endregion

                    #region #Z
                    #endregion

                    #region #W                
                    (TAG_Welcome(true), TAG_Welcome(false)),
                    #endregion

                    #region #Y
                    #endregion

                    #region #@
                    #endregion
                #endregion
            };
        }

        #region #Tags
            #region #A
            #endregion

            #region #B
            #endregion

            #region #C
            public string TAG_Calculator(bool JustTag = false)
            {
                if (JustTag)
                    return "TAG_Calculator";
                else
                {
                    switch (Language)
                    {
                        case "ES-ES":
                            return "Calculadora";
                        case "PT-BR":
                            return "Calculadora";
                        default:
                            return "Calculator";
                    }
                }
            }
            #endregion

            #region #D
            #endregion

            #region #E
            #endregion

            #region #F
            #endregion

            #region #G
            #endregion

            #region #H
            public string TAG_Help(bool JustTag = false)
            {
                if (JustTag)
                    return "TAG_Help";
                else
                {
                    switch (Language)
                    {
                        case "ES-ES":
                            return "Ayuda";
                        case "PT-BR":
                            return "Ajuda";
                        default:
                            return "Help";
                    }
                }
            }
            #endregion

            #region #I
            #endregion

            #region #J
            #endregion

            #region #K
            #endregion

            #region #L
            public string TAG_Login(bool JustTag = false)
            {
                if (JustTag)
                    return "TAG_Login";
                else
                {
                    switch (Language)
                    {
                        case "ES-ES":
                            return "Iniciar sesión";
                        case "PT-BR":
                            return "Entrar";
                        default:
                            return "Login";
                    }
                }
            }
            
            public string TAG_Logo(bool JustTag = false)
            {
                if (JustTag)
                    return "TAG_Logo";
                else
                {
                    switch (Language)
                    {
                        case "ES-ES":
                            return "Logo";
                        case "PT-BR":
                            return "Logo";
                        default:
                            return "Logo";
                    }
                }
            }
            #endregion

            #region #M
            #endregion

            #region #N
            #endregion

            #region #O
            #endregion

            #region #P
            public string TAG_Password(bool JustTag = false)
            {
                if (JustTag)
                    return "TAG_Password";
                else
                {
                    switch (Language)
                    {
                        case "ES-ES":
                            return "Contraseña";
                        case "PT-BR":
                            return "Senha";
                        default:
                            return "Password";
                    }
                }
            }
            #endregion

            #region #Q
            #endregion

            #region #R
            #endregion

            #region #S
            #endregion

            #region #T
            #endregion

            #region #U
            public string TAG_User(bool JustTag = false)
            {
                if (JustTag)
                    return "TAG_User";
                else
                {
                    switch (Language)
                    {
                        case "ES-ES":
                            return "Usuario";
                        case "PT-BR":
                            return "Usuário";
                        default:
                            return "User";
                    }
                }
            }
            #endregion

            #region #V
            #endregion

            #region #X
            #endregion

            #region #Z
            #endregion

            #region #W
            public string TAG_Welcome(bool JustTag = false)
            {
                if (JustTag)
                    return "TAG_Welcome";
                else
                {
                    switch (Language)
                    {
                        case "ES-ES":
                            return "Bienvenido";
                        case "PT-BR":
                            return "Bem-vindo";
                        default:
                            return "Welcome";
                    }
                }
            }
            #endregion

            #region #Y
            #endregion

            #region #@
            #endregion
        #endregion
    }
}
