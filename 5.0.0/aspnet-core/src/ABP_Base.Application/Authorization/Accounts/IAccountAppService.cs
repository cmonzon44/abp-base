using System.Threading.Tasks;
using Abp.Application.Services;
using ABP_Base.Authorization.Accounts.Dto;

namespace ABP_Base.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
