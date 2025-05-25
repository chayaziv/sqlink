using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsCore.EntityDTO;
using TicketsCore.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TicketsCore
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<TicketDTO, Ticket>().ReverseMap();
        }
       
    }
}
