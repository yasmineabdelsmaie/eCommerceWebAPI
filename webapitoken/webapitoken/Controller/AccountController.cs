using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using webapitoken.Model;

namespace webapitoken.Controller
{
    public class AccountController : ApiController
    {
        public async Task<IHttpActionResult> postUser(usermodel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Usermanager
            ApplicationDbContext dbcontext = new ApplicationDbContext();
            UserStore<IdentityUser> userstore = new UserStore<IdentityUser>(dbcontext);
            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userstore);

            //Map from UserModel to IdentityUser
            IdentityUser user = new IdentityUser();
            user.UserName = userModel.Name;
            user.PasswordHash = userModel.Password;
            //create 
            IdentityResult result = await manager.CreateAsync(user, userModel.Password);
            //ok
            if (result.Succeeded)
                return Created("", "User Added");
            return BadRequest(result.Errors.ToList()[0]);
            //badrequ
        }
    }
}
