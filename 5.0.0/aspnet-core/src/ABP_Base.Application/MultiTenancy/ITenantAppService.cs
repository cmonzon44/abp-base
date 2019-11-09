using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABP_Base.MultiTenancy.Dto;

namespace ABP_Base.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

