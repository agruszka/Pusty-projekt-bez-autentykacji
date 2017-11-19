using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Mail.Repo
{
    public class RepositoryAbstract<T> where T: class

    {
        public virtual void Create(T entity)
        {
            using (var context = new Models.AppContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }


        public virtual void Update (T entity)
        {
            using (var context = new Models.AppContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }


        public virtual List<T> GetWhere(Expression<Func<T, bool>> expression) //zeby mzona bylo uzyc lambdy
        {
            using (var context = new Models.AppContext())
            {
                var query = context.Set<T>().Where(expression);
                return query.ToList();
            }
        }

        public virtual void Delete (T entity)
        {
            using (var context = new Models.AppContext())
            {
                context.Set<T>().Remove(entity);
            }
        }
    }


}