using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class RepositoryEmployees : BaseRepository<Employees>
    {
        public void SendInvite()
        {
            //to do 
        }
        public void RemoveEmploees(int id)
        {
            using(var context = new EmployeesDb())
            {
                context.Entry<Employees>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
