using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsCore.Models;

namespace TicketsCore.IData
{
    public interface IDataContext
    {
        public List<Ticket> Tickets { get; set; }
        public List<User> Users { get; set; }
        public List<Status> Statuses { get; set; }
        public bool LoadData();
        public bool SaveData();
    }
}
