using System;

namespace Authoritis.Web.Models
{
    public class ModerationIssueModel : Query.Interface.Models.IModerationIssue
    {
        public DateTime ClearedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Field { get; set; }
        public string IssueNotedBy { get; set; }
        public string Reason { get; set; }
        public int Status { get; set; }
    }
}
