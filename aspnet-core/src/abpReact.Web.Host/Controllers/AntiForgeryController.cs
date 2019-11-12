using Microsoft.AspNetCore.Antiforgery;
using abpReact.Controllers;

namespace abpReact.Web.Host.Controllers
{
    public class AntiForgeryController : abpReactControllerBase
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
