using System.Data.Entity;

namespace WebPortalUI.Models.DB
{
    public interface IBaseContext
    {
        DbContext DbContext { get; }
    }
}
