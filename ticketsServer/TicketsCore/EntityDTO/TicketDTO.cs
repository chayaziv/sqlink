using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsCore.EntityDTO
{
    public class TicketDTO
    {


        public int ? TicketId { get; set; } = 0;

        public string FullName { get; set; }
       = string.Empty;

        public string Email { get; set; }

        = string.Empty;

        public string Description { get; set; }


        public string ImageUrl { get; set; }


    }
}
