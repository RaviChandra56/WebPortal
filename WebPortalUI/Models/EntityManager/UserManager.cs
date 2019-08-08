using System;
using System.Linq;
using WebPortalUI.Models.DB;
using WebPortalUI.Models.EntityDataModel;
using WebPortalUI.Models.ViewModel;

namespace WebPortalUI.Models.EntityManager
{
    public class UserManager : IUserManager
    {
        private IContextFactory _contextFactory;
        public UserManager(IContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void AddUserAccount(UserSignUpViewModel user)
        {
            try
            {
                using (var context = _contextFactory.UserContextInstance())
                {
                    SYSUser SU = new SYSUser();
                    SU.LoginName = user.LoginName;
                    SU.PasswordEncryptedText = user.Password;
                    SU.CreatedUserID = user.SYSUserID > 0 ? user.SYSUserID : 1;
                    SU.ModifiedUserID = user.SYSUserID > 0 ? user.SYSUserID : 1;
                    SU.CreatedDateTime = DateTime.Now;
                    SU.ModifiedDateTime = DateTime.Now;
                    context.SYSUser.Add(SU);

                    SYSUserProfile SUP = new SYSUserProfile();
                    SUP.SYSUserID = SU.SYSUserID;
                    SUP.FirstName = user.FirstName;
                    SUP.LastName = user.LastName;
                    SUP.Gender = user.Gender;
                    SUP.CreatedUserID = user.SYSUserID > 0 ? user.SYSUserID : 1;
                    SUP.ModifiedUserID = user.SYSUserID > 0 ? user.SYSUserID : 1;
                    SUP.CreatedDateTime = DateTime.Now;
                    SUP.ModifiedDateTime = DateTime.Now;
                    context.SYSUserProfile.Add(SUP);

                    if (user.LOOKUPRoleID > 0)
                    {
                        SYSUserRole SUR = new SYSUserRole();
                        SUR.LOOKUPRoleID = user.LOOKUPRoleID;
                        SUR.SYSUserID = user.SYSUserID;
                        SUR.IsActive = true;
                        SUR.CreatedUserID = user.SYSUserID > 0 ? user.SYSUserID : 1;
                        SUR.ModifiedUserID = user.SYSUserID > 0 ? user.SYSUserID : 1;
                        SUR.CreatedDateTime = DateTime.Now;
                        SUR.ModifiedDateTime = DateTime.Now;

                        context.SYSUserRole.Add(SUR);
                    }

                    context.DbContext.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public bool IsLoginNameExist(string loginName)
        {
            try
            {
                using (var context = _contextFactory.Instance<SYSUser>())
                {
                    return context.DbSet.Where(o => o.LoginName.Equals(loginName)).Any();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}