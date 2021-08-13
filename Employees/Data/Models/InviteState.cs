using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class InviteState : Base
    {
        public string State { get; set; }
        public DateTime DateSend { get; set; }
        public DateTime DateResponse { get; set; }
        public string Description { get; set; }
    }
}
