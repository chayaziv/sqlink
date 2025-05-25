using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TicketsCore.Models;

namespace TicketsData.data
{
    public class FormatData
    {
        [JsonPropertyName("tickets")]
        public List<Ticket> Tickets { get; set; }

        [JsonPropertyName("users")]
        public List<User> Users { get; set; }

        [JsonPropertyName("statuses")]
        public List<Status> Statuses { get; set; }
    }
}
