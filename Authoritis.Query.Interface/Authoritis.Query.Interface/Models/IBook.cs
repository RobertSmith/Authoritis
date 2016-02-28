using System;
using System.Collections.Generic;

namespace Authoritis.Query.Interface.Models
{
    public interface IBook
    {
        string Key { get; set; }
        List<IAuthor> Authors { get; set; }
        string Title { get; set; }
        string SubTitle { get; set; }
        string SeriesTitle { get; set; }
        string SeriesVolume { get; set; }
        IGenre Genre { get; set; }
        ILanguage Language { get; set; }
        string CoverArtKey { get; set; }
        string Synopsis { get; set; }
        bool Published { get; set; }
        bool Completed { get; set; }
        bool Abandoned { get; set; }
        bool DMCA { get; set; }
        List<IModerationIssue> ModerationIssues { get; set; }
        DateTime CreatedAt { get; set; }
        Guid CreatedBy { get; set; }
        DateTime UpdatedAt { get; set; }
        Guid UpdatedBy { get; set; }

        string CoverArtUri { get; }
    }
}
