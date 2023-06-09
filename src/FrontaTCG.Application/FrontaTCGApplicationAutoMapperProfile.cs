using AutoMapper;
using FrontaTCG.Cards;
using FrontaTCG.CardsDTO;

namespace FrontaTCG;

public class FrontaTCGApplicationAutoMapperProfile : Profile
{
    public FrontaTCGApplicationAutoMapperProfile()
    {
        CreateMap<Card,CardDTO>();
        CreateMap<CardDTO_Create_Update, CardDTO>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
