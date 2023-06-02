using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace FrontaTCG.Cards
{
    public class CardAbility : AuditedAggregateRoot<int>
    {
        public string AbilityName { get; set; }
        public string AbilityDescription { get; set; }
        public byte ActivationCount { get; set; }
        public int ActivationRange { get; set; }

    }
}
