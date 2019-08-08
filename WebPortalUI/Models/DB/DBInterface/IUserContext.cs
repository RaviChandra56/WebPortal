using System;
using System.Data.Entity;
using WebPortalUI.Models.EntityDataModel;

namespace WebPortalUI.Models.DB
{
    public interface IUserContext: IBaseContext, IDisposable
    {
        DbSet<SYSUser> SYSUser { get; set; }
        DbSet<SYSUserProfile> SYSUserProfile { get; set; }
        DbSet<SYSUserRole> SYSUserRole { get; set; }
    }
}
