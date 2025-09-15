using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SodexoApi.Models;
using System.IdentityModel.Tokens.Jwt;
using SodexoApi.Services;
using System.Data;

namespace SodexoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IConfiguration _configManager;
        public AccountController(IConfiguration configurationManager) { 
        _configManager = configurationManager;
        }
        [HttpPost("login")]
        public ActionResult<Access> Login()
        {
            var roles = "HrPortal_Prestation_Writer,HrPortal_Contract_Writer,HrPortal_LeavePlanner_Writer,Indexation_Admin,ClientConnection_ClientInvoice_Reader,Dwh_Reader,Dwh_WhosWho_Reader,Incident_Creater,VendingRequest_Reader,Allergen_Admin,BugTracking_Admin,ClientConnection_Admin,ClientConnection_ClientInvoice_Admin,ClientConnection_Library_Admin,Dwh_Admin,Incident_Admin,Log_Admin,MappingFile_Admin,Resource_Admin,SAPProfitCenter_Admin,VendingRequest_Admin".Split(",");

            var user = new User { Email = "email", Name = "email@email.com" };
            if (user is not null)
            {
                var authClaims = new List<Claim>
                    {
                    new Claim(ClaimTypes.Name, ""),
                    new Claim(ClaimTypes.Surname, ""),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),                    
                    };
                authClaims.AddRange(roles.Select(r => new Claim(ClaimTypes.Role, r)));
                var token = AccessService.GetToken(authClaims, _configManager);
                return new Access { HasAccess = true, Token = token };
            }
            else
            {
                return new Access { HasAccess = false, Token = string.Empty };
            }

        }
       
    }
}
