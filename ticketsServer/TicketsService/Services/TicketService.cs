using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsCore.EntityDTO;
using TicketsCore.IData;
using TicketsCore.IServices;
using TicketsCore.Models;
using TicketsCore.Utils;

namespace TicketsService.Services
{
    public class TicketService : ITicketService
    {
        private readonly IMapper _mapper;

        private readonly IDataContext _dataContext;

        private int _id;


        public TicketService(IMapper mapper, IDataContext dataContext)
        {

            _mapper = mapper;
            _dataContext = dataContext;
            _id = 0;
        }
        public Result<List<TicketDTO>> AddTicket(TicketDTO ticket)
        {
            var entity = _mapper.Map<Ticket>(ticket);
            var sucsess = _dataContext.LoadData();
            if (entity == null)
            {
                return Result<List<TicketDTO>>.BadRequest("error on mapping ticketDTO to TIcket");
            }

            if (!sucsess)
                return Result<List<TicketDTO>>.BadRequest("Error in loading data json");
          

            entity.StatusId = 1;
            entity.TicketId = _id++;

            _dataContext.Tickets.Add(entity);
            _dataContext.SaveData();
            return Result<List<TicketDTO>>.Success(_mapper.Map<List<TicketDTO>>(_dataContext.Tickets));
        }

        public Result<List<Ticket>> GetTickets()
        {

            var sucsess = _dataContext.LoadData();


            if (!sucsess)
                return Result<List<Ticket>>.BadRequest("Error in loading data json");

            return Result<List<Ticket>>.Success(_dataContext.Tickets);
        }

        public Result<Ticket> GetById(int id)
        {

            var sucsess = _dataContext.LoadData();


            if (!sucsess)
                return Result<Ticket>.BadRequest("Error in loading data json");

            var entity = _dataContext.Tickets.Where(c => c.TicketId == id).FirstOrDefault();
            if (entity == null)
                return Result<Ticket>.NotFound();
            return Result<Ticket>.Success(entity);
        }

    }
}
