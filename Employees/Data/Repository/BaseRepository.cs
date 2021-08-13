using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepository<T> where T : Base
    {
        public void Create(T model)
        {
            using(var context = new EmployeesDb())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public List<T> Read()
        {
            List<T> list = new List<T>();
            using (var context = new EmployeesDb())
            {
                list = context.Set<T>().ToList();
            }
            return list;
        }
        public T Read(int id)
        {
            T model = Activator.CreateInstance<T>();
            using (var context = new EmployeesDb())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }
        public void Update(T model)
        {
            using (var context = new EmployeesDb())
            {
                context.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
