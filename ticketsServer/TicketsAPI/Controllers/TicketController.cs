using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketsCore.EntityDTO;
using TicketsCore.IServices;

namespace TicketsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {



        private readonly ITicketService _ticketService;


        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;

        }

        [HttpPost]

        public  ActionResult<TicketDTO> Post([FromBody] TicketDTO ticket)
        {
            Console.WriteLine(  "hello!!");
            var result =  _ticketService.AddTicket(ticket);
            if (!result.IsSuccess)
            {
                return StatusCode(result.StatusCode, new { messege = result.ErrorMessage });
            }
            return StatusCode(result.StatusCode, new { data = result.Data });
        }

        [HttpGet("hello")]

        public ActionResult<bool> Test()
        {
            
            return StatusCode(200, new { data = "hello Tickets controller"});
        }

        [HttpGet]
       
        public ActionResult<List<TicketDTO>> Get()
        {
            var result = _ticketService.GetTickets();
            if (!result.IsSuccess)
            {
                return StatusCode(result.StatusCode, new { messege = result.ErrorMessage });
            }
            return StatusCode(result.StatusCode, new { data = result.Data });
        }

        [HttpGet("{id}")]
       
        public ActionResult<TicketDTO> Get(int id)
        {
            var result =_ticketService.GetById(id);
            if (!result.IsSuccess)
            {
                return StatusCode(result.StatusCode, new { messege = result.ErrorMessage });
            }
            return StatusCode(result.StatusCode, new { data = result.Data });
        }

    }
}
