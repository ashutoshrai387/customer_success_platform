﻿using NUglify;
using Volo.Abp.Domain.Entities.Auditing;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class Project : AuditedEntity<Guid>
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public virtual ICollection<Document>? Documents { get; set; }
        public virtual ProjectBudget? Budget { get; set; }        
        public virtual ICollection<EscalationMatrix>? EscalationMatrices { get; set; }
        public virtual ICollection<RiskProfile>? RiskProfiles { get; set; }
        public virtual ICollection<PhaseMilestone>? PhaseMilestones { get; set; }
        public virtual ICollection<Resource> Resources { get; set; } = new List<Resource>();
        public virtual ICollection<ClientFeedback> ClientFeedbacks { get; set; } = new List<ClientFeedback>();
        public virtual ICollection<MeetingMinute> MeetingMinutes { get; set; } = new List<MeetingMinute>();
    }
}
