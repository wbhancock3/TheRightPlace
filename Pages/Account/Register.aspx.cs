using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheRightPlace.Pages.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();

            userStore.Context.Database.Connection.ConnectionString =
                System.Configuration.ConfigurationManager.
                ConnectionStrings["F17_kswbhancoConnectionString"].ConnectionString;

            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

            //create new user and try to store in db
            IdentityUser user = new IdentityUser();
            user.UserName = txtUsername.Text;

            if(txtPassword.Text == txtConfirmPassword.Text)
            {
                try
                {
                    //create user object
                    //db will be created/expanded automatically
                    IdentityResult result = manager.Create(user, txtPassword.Text);

                    if(result.Succeeded)
                    {
                        //store user in db
                        var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

                        //set to log in new user by cookie
                        var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                        //log in the new user and redirect to homepage
                        authenticationManager.SignIn(new Microsoft.Owin.Security.AuthenticationProperties(), userIdentity);
                        Response.Redirect("~/Pages/Index.aspx");
                    }
                    else
                    {
                        litStatus.Text = result.Errors.FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {
                    litStatus.Text = ex.ToString();
                }
            }
            else
            {
                litStatus.Text = "Passwords must match.";
            }
        }
    }
}