using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System;
using FlightBookingSystem.Models;

namespace FBS.DAL
{
    public static class EmailProvider
    {
        public static void Email(string rec, BookingsModel model, FlightModel fmodel)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("flightbookingsystem8@gmail.com");
                mail.To.Add(rec);
                mail.Subject = "You just booked a flight!";
                mail.Body = "Flight Details:\n" +
                    "Username: " + model.Name + " " + model.Surname + "\n" +
                    "Age: " + model.Age + "\n" +
                    "Departure Airport: " + fmodel.DepartureAirport + "\n" + 
                    "Arrival Airport: " + fmodel.ArrivalAirport + "\n"+
                    "Date Time: " + fmodel.DateTime + "\n\n\n" +
                    "Have a nice Trip <3";
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential("flightbookingsystem8@gmail.com", "ilnncqpthgfznkib");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);

                }
            }
        }
    }
}
