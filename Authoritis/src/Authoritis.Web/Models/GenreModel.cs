namespace Authoritis.Web.Models
{
    public class GenreModel : Authoritis.Query.Interface.Models.IGenre
    {
        public bool IsFiction { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
    }
}