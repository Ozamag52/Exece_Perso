using System;
using Exece_Perso.Entities.Class;
using Exece_Perso.Entities.Exceptions;
namespace Exece_Perso
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in data (dd/MM/yy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-in data (dd/MM/yy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation);

                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation: ");
                Console.Write("Check-in data (dd/MM/yy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-in data (dd/MM/yy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine(reservation);
            }

            catch(DomainException e)
            {
                Console.WriteLine("Reservation erro: " + e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

         }   
    }
}
