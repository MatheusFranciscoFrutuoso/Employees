using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    class PositionRepository:BaseRepository<Position>
    {

        Position position = new Position();

        Employees employees = new Employees();



        public void setPosition( int id_Employee, int id_Position)
        {

            RepositoryEmployees repor = new RepositoryEmployees();
            position = Read(id_Position);

            employees = repor.Read(id_Employee);
        }



    }
}
