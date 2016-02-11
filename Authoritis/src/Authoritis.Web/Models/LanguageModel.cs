namespace Authoritis.Web.Models
{
    public class LanguageModel : Query.Interface.Models.ILanguage
    {
        public string Key { get; set; }
        public string Name { get; set; }
    }
}
