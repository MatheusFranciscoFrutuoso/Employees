using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class EmployeesDb : DbContext
    {
        public DbSet<InviteState> InviteState { get; set; }
        public EmployeesDb():base ("Data Source=192.168.0.114;Initial Catalog=Employees;Persist Security Info=True;User ID=Employees;Password=projetox")
        {

        }
    }
}
