using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TicketsCore.Models
{
    public class Ticket
    {



        [JsonPropertyName("ticketId")]
        public int TicketId { get; set; }


        [JsonPropertyName("fullName")]
        public string FullName { get; set; }
        = string.Empty;

        [JsonPropertyName("email")]
        public string Email { get; set; }

        = string.Empty;


        [JsonPropertyName("statusId")]
        public int StatusId { get; set; }


        [JsonPropertyName("description")]
        public string Description { get; set; }


        [JsonPropertyName("summary")]
        public string Summary { get; set; }


        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }


        [JsonPropertyName("solution")]
        public string Solution { get; set; }
    }
}
