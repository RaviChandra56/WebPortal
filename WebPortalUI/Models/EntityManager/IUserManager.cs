using WebPortalUI.Models.ViewModel;

namespace WebPortalUI.Models.EntityManager
{
    public interface IUserManager
    {
        void AddUserAccount(UserSignUpViewModel user);
        bool IsLoginNameExist(string loginName);
    }
}
