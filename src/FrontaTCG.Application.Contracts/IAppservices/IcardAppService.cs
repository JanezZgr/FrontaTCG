using FrontaTCG.CardsDTO;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FrontaTCG.IAppservices
{
    public interface IcardAppService : ICrudAppService<CardDTO, Guid, PagedAndSortedResultRequestDto, CardDTO_Create_Update>
    { }
    
}
