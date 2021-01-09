using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Model;
using HotelReservation;
using System.Windows.Forms;

namespace Controllers
{
    public class ReservationController
    {
        ReservationDbContext db = new ReservationDbContext();

        public void Create(Reservation reservation)
        {
            reservation.NameofReservation = TextBox.Text;
        }

    }
}
