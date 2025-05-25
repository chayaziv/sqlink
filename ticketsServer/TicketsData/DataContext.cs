using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TicketsCore.IData;
using TicketsCore.Models;
using TicketsData.data;

namespace TicketsData
{
    public class DataContext : IDataContext
    {

        public List<Ticket> Tickets { get; set; }= new List<Ticket>();
        public List<User> Users { get; set; } = new List<User>();
        public List<Status> Statuses { get; set; } = new List<Status>();

       

           readonly string _filePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\..\TicketsData\jsonFile"));

        public DataContext()
        {
        }


        public bool LoadData()
        {
            
            string path = Path.Combine(_filePath, "data.json");

            try
            {
                string jsonString = File.ReadAllText(path);
                var DB = JsonSerializer.Deserialize<FormatData>(jsonString);// typeof(DataCoins)); 
                if (DB == null)
                    return false;
              
                Tickets = DB.Tickets ?? new List<Ticket>() { };
                Users = DB.Users ?? new List<User> { };
                Statuses = DB.Statuses ?? new List<Status> { };
            }
            catch {

                Tickets =  new List<Ticket>() { };
                Users =  new List<User> { };
                Statuses = new List<Status> { };
            }


            
            return true;
        }


        public bool SaveData()
        {

           
            try
            {
               
                string path = Path.Combine(_filePath, "data.json");
                FormatData DB = new FormatData();
                if(DB == null) return false;
                DB.Tickets = Tickets ?? new List<Ticket>() { }; ;
                //DB.Users = Users ?? new List<User> { }; ;
                //DB.Statuses = Statuses ?? new List<Status> { }; ;

                string jsonString = JsonSerializer.Serialize<FormatData>(DB);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
