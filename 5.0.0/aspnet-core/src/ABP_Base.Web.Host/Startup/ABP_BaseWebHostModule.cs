using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP_Base.Configuration;

namespace ABP_Base.Web.Host.Startup
{
    [DependsOn(
       typeof(ABP_BaseWebCoreModule))]
    public class ABP_BaseWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABP_BaseWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABP_BaseWebHostModule).GetAssembly());
        }
    }
}
