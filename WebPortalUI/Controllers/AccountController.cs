using System.Web.Mvc;
using System.Web.Security;
using WebPortalUI.Models.EntityManager;
using WebPortalUI.Models.ViewModel;

namespace WebPortalUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserManager _userManager;
        public AccountController(IUserManager userManager)
        {
            this._userManager = userManager;
        }
        // GET: Account
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UserSignUpViewModel USV)
        {
            if (ModelState.IsValid)
            {
                if (!_userManager.IsLoginNameExist(USV.LoginName))
                {
                    _userManager.AddUserAccount(USV);
                    FormsAuthentication.SetAuthCookie(USV.FirstName, false);

                    return RedirectToAction("Welcome", "Home");
                }
                else
                    ModelState.AddModelError("", "Login Name already taken.");
            }
            return View();
        }
    }
}