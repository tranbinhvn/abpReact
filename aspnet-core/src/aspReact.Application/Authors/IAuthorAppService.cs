using Abp.Application.Services;
using Abp.Application.Services.Dto;
using aspReact.Authors.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace aspReact.Authors
{
    public interface IAuthorAppService: IApplicationService
    {
        Task<ListResultDto<GetAuthorOutput>> ListAll();
        Task Create(CreateAuthorInput input);
        void Update(UpdateAuthorInput input);
        void Delete(DeleteAuthorInput input);
        GetAuthorOutput GetAuthorById(GetAuthorInput input);
    }
}
