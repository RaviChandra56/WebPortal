using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace WebPortalUI.Models.DB
{
    public class Context<T> : BaseContext, IContext<T> where T : class
    {
        public Context(string connectionString)
            : base(connectionString)
        {
        }
        public virtual IDbSet<T> DbSet { get; set ; }

        public void DetachEntity(T entity)
        {
            ((IObjectContextAdapter)this.DbContext).ObjectContext.Detach(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.AsEnumerable().ToList();
        }

        public void Update(T entity)
        {
            if (Entry(entity).State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }

            Entry(entity).State = EntityState.Modified;
        }
    }
}