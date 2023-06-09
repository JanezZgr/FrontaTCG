using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FrontaTCG.CardsDTO
{
    public class CardDTO_Create_Update
    {
        [Required]
        CardEnums.CardType CardType { get; set; }
        [Required]
        public string CardName { get; set; }
        [Required]
        public int CostMaterial { get; set; }
        [Required]
        public int CostManpower { get; set; }
        [Required]
        public int Ability1 { get; set; }
    }
}
