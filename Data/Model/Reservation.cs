using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
   public class Reservation
    {
        
        public int Id { get; set; }
        public string NameofReservation { get; set; }
        public string Age { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public bool Smoke { get; set; }
        public double CalculatedPrice { get; set; }
        public DateTime PeriodOfReservation { get; set; }
    }
}
