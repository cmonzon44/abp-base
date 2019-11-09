using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP_Base.Authorization;

namespace ABP_Base
{
    [DependsOn(
        typeof(ABP_BaseCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABP_BaseApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABP_BaseAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABP_BaseApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
