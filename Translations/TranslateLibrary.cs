using System;

namespace LABChromaAI.App.Translations 
{
    public class TranslateLibrary
    {
        private static string Systems_Language = "PT-BR";
        private static List<(string Tag, string Value)> ListAllTags = new List<(string Tag, string Value)>();
        private Tags Tags = new Tags(Systems_Language);

        public string GetTranslatedTag(string Tag, bool ClearList = false)
        {
            LoadListAllTranslatedTags(ClearList);

            return ListAllTags.Where(x => x.Tag == Tag).Select(y => y.Value).FirstOrDefault() ?? "TAG_ZZZ";
        }

        public List<(string Tag, string Value)> GetListAllTranslatedTags(bool ClearList = false)
        {
            LoadListAllTranslatedTags(ClearList);

            return ListAllTags;
        }
        
        public void LoadListAllTranslatedTags(bool ForceClearList = false)
        {
            if (ListAllTags == null || ListAllTags.Count() < 1)
            {
                ListAllTags = Tags.GetListAllTranslatedTags();
            }
            else
            {
                if (ForceClearList)
                {
                    ListAllTags.Clear();
                    ListAllTags = Tags.GetListAllTranslatedTags();
                }
            }
        }
    }
}
