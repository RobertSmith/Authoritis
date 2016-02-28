using Authoritis.Query.Interface.Models;

namespace Authoritis.Web.Models
{
    public class GenreModel : IGenre
    {
        public bool IsFiction { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
    }
}