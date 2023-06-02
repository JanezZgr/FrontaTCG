using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace FrontaTCG.Cards
{
    public class UnitCard : AuditedAggregateRoot<Guid>
    {
        public Card Card { get; set; }
      //  public Guid cardID { get; set; }
        public int DmgUnarmored { get; set; }
        public int DmgArmored { get; set; }
        public int DmgStructure { get; set; }
        public int DmgAir { get; set; }
       
        public CardAbility Ability2 { get; set; }
    }
}
