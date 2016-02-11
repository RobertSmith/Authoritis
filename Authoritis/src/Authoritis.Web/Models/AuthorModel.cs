namespace Authoritis.Web.Models
{
    public class AuthorModel : Query.Interface.Models.IAuthor
    {
        public string Key { get; set; }

        public string Name { get; set; }
    }
}