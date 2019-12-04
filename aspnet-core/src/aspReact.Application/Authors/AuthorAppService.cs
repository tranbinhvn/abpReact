using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.UI;
using aspReact.Authorization;
using aspReact.Authors.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using reactjs.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace aspReact.Authors
{
    [AbpAuthorize(PermissionNames.Pages_Authors)]
    public class AuthorAppService : ApplicationService, IAuthorAppService
    {
        private readonly IAuthorManager _authorManager;
        public AuthorAppService(IAuthorManager authorManager)
        {
            _authorManager = authorManager;
            LocalizationSourceName = aspReactConsts.LocalizationSourceName;
        }

        public async Task Create(CreateAuthorInput input)
        {
            Author author = ObjectMapper.Map<Author>(input);
            await _authorManager.Create(author);
        }

        public void Delete(DeleteAuthorInput input)
        {
            _authorManager.Delete(input.Id);
        }

        public GetAuthorOutput GetAuthorById(GetAuthorInput input)
        {
            var author = _authorManager.GetAuthorById(input.Id);
            var result = ObjectMapper.Map<GetAuthorOutput>(author);
            return result;
        }
        //public async Task<ListResultDto<RoleDto>> GetRoles()
        //{
        //    var roles = await _roleRepository.GetAllListAsync();
        //    return new ListResultDto<RoleDto>(ObjectMapper.Map<List<RoleDto>>(roles));
        //}
        [HttpGet]
        public async Task<ListResultDto<GetAuthorOutput>> ListAll()
        {
            var test1 = L("TenantName_Regex_Description");

            Logger.Info("Test logger.Info");
            var authors = _authorManager.GetAllList();
            var result = await authors.ToListAsync();
            return new ListResultDto<GetAuthorOutput>(ObjectMapper.Map<List<GetAuthorOutput>>(result));
        }

        [HttpGet]
        public async Task<ListResultDto<GetAuthorOutput>> ListAllPaging()
        {
            try
            {
                var authors = _authorManager.GetAllList();
                var result = await authors.ToListAsync();
                var test = new ListResultDto<GetAuthorOutput>(ObjectMapper.Map<List<GetAuthorOutput>>(result));
                return test;
            }
            catch (System.Exception ex)
            {

                throw new UserFriendlyException(ex.ToString());
            }
           
        }

        public void Update(UpdateAuthorInput input)
        {
            var author = ObjectMapper.Map<Author>(input);
            _authorManager.Update(author);
        }
    }
}
