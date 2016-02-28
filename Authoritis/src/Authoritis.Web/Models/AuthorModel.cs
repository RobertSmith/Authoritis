using Authoritis.Query.Interface.Models;

namespace Authoritis.Web.Models
{
    public class AuthorModel : IAuthor
    {
        public string Key { get; set; }
        public string Name { get; set; }
    }
}