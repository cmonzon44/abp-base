using System.Threading.Tasks;
using Abp.Application.Services;
using ABP_Base.Sessions.Dto;

namespace ABP_Base.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
