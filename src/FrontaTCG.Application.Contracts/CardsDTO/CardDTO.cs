using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace FrontaTCG.CardsDTO
{
    public class CardDTO:AuditedEntityDto<Guid>
    {
        CardEnums.CardType CardType { get; set; }
        public string CardName { get; set; }
        public int CostMaterial { get; set; }
        public int CostManpower { get; set; }
        public int Ability1 { get; set; }
    }
}
