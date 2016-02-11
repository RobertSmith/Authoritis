using System;
using System.Collections.Generic;

namespace Authoritis.Web.Models
{
    public class BookModel : Query.Interface.Models.IBook
    {
        public bool Abandoned { get; set; }
        public List<Query.Interface.Models.IAuthor> Authors { get; set; }
        public bool Completed { get; set; }
        public string CoverArtKey { get; set; }
        public string CoverArtUri => $"http://krakkl.blob.core.windows.net/{Key}/{CoverArtKey}";
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public bool DMCA { get; set; }
        public Query.Interface.Models.IGenre Genre { get; set; }
        public string Key { get; set; }
        public Query.Interface.Models.ILanguage Language { get; set; }
        public List<Query.Interface.Models.IModerationIssue> ModerationIssues { get; set; }
        public bool Published { get; set; }
        public string SeriesTitle { get; set; }
        public string SeriesVolume { get; set; }
        public string SubTitle { get; set; }
        public string Synopsis { get; set; }
        public string Title { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
