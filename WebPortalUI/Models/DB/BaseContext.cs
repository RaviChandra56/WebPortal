using System.Data.Entity;

namespace WebPortalUI.Models.DB
{
    public class BaseContext : DbContext
    {
        public BaseContext(string connectionString)
            : base(connectionString)
        { }

        public DbContext DbContext
        {
            get { return this; }
        }

        public System.Data.Entity.DbSet<WebPortalUI.Models.ViewModel.UserSignUpViewModel> UserSignUpViewModels { get; set; }
    }
}