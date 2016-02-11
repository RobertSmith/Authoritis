namespace Authoritis.Query.Interface.Models
{
    public interface IGenre
    {
        string Key { get; set; }
        string Name { get; set; }
        bool IsFiction { get; set; }
    }
}