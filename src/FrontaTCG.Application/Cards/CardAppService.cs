using FrontaTCG.CardsDTO;
using FrontaTCG.IAppservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace FrontaTCG.Cards
{
    public class CardAppService : CrudAppService<Card, CardDTO, Guid, PagedAndSortedResultRequestDto, CardDTO_Create_Update>, IcardAppService
    {
        public CardAppService(IRepository<Card, Guid> repository) : base(repository)
        {
        }
    }
}
