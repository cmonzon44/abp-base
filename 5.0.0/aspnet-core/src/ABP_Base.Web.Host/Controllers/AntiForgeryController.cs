using Microsoft.AspNetCore.Antiforgery;
using ABP_Base.Controllers;

namespace ABP_Base.Web.Host.Controllers
{
    public class AntiForgeryController : ABP_BaseControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
