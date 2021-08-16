using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
        public class TeamRepository : BaseRepository<Team>
        {
            RepositoryEmployees empRepo = new RepositoryEmployees();
            Team teams;
            Employees employ;

            public void AddMember(int id_Employee, int id_Team)
            {
                teams = this.Read(id_Team);
                employ = empRepo.Read(id_Employee);
                teams.Member.Add(employ);
            }
            public void RemoveMember(int id_Employee)
            {
                employ = empRepo.Read(id_Employee);
                teams = this.Read(employ.Team.Id);
                teams.Member.Remove(employ);
            }
            public void TransferMember(int id_Employee, int id_Team)
            {
                this.RemoveMember(id_Employee);
                this.AddMember(id_Employee, id_Team);
            }
        }
}
