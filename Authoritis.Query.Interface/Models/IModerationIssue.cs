using System;

namespace Authoritis.Query.Interface.Models
{
    public interface IModerationIssue
    {
        string Field { get; set; }
        string Reason { get; set; }
        string IssueNotedBy { get; set; }
        int Status { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime ClearedAt { get; set; }
    }
}