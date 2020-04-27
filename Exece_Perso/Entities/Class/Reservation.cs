using System;
using Exece_Perso.Entities.Exceptions;

namespace Exece_Perso.Entities.Class
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkIn < DateTime.Now)
            {
                throw new DomainException("The check in should be a future day");

            }
            if (checkOut <= CheckIn)
            {
                throw new DomainException("The check in should be a date before the check out ");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            if(checkIn < DateTime.Now)
            {
                throw new DomainException("The check in should be a future day");
                   
            }
            if (checkOut <= CheckIn)
            {
                throw new DomainException("The check in should be a date before the check out ");
            }
        }


        public override string ToString()
        {
            return "Reservation: "
                + "Room: " 
                + RoomNumber
                + ", " + 
                "check-in: " + 
                CheckIn + 
                ", " + 
                "check-out: " 
                + CheckOut 
                + ", " 
                + Duration()
                + " nights";
        }
    }
}
