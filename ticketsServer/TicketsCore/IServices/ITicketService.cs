using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsCore.EntityDTO;
using TicketsCore.Models;
using TicketsCore.Utils;

namespace TicketsCore.IServices
{
    public interface ITicketService
    {
        Result<List<TicketDTO>> AddTicket(TicketDTO ticket);
        public Result<List<Ticket>> GetTickets();
        public Result<Ticket> GetById(int id);
    }
}
