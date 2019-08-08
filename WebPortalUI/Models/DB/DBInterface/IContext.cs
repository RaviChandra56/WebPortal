using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace WebPortalUI.Models.DB
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")]
    public interface IContext<T> : IBaseContext, IDisposable where T : class
    {
        IDbSet<T> DbSet { get; set; }
        IEnumerable<T> GetAll();
        void Update(T entity);
        void DetachEntity(T entity);
    }
}
