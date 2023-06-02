using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace FrontaTCG.Cards
{
    public class Card : AuditedAggregateRoot<Guid>
    {
        CardEnums.CardType CardType { get; set; }
        public string CardName { get; set; }
        public int CostMaterial { get; set; }
        public int CostManpower { get; set; }
        public CardAbility Ability1 { get; set; }
    }
}
