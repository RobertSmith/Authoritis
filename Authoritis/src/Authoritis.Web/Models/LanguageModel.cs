using Authoritis.Query.Interface.Models;

namespace Authoritis.Web.Models
{
    public class LanguageModel : ILanguage
    {
        public string Key { get; set; }
        public string Name { get; set; }
    }
}
