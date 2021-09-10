using System;

namespace MovieTicketBooking
{
    
    class MovieTicket
    {
        internal int n = 0;
        char reply;
       public void Movie()
        {
            Console.WriteLine("Do you want to book movie ticket? type Y/N");
            reply = Convert.ToChar (Console.ReadLine());
            if (reply == 'Y'||reply=='y')
            {
                Console.WriteLine("How many tickets you want to book");
                 n = Convert.ToInt32(Console.ReadLine());
                if (n <= 20)
                {
                    Console.WriteLine("Tickets booked Successfully...");
                }
                else
                {
                    throw (new TicketLimitException("There are only 20 tickets available"));
                }

            }

        }
    }
    public class TicketLimitException : ApplicationException
    {
        public TicketLimitException(string message) : base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MovieTicket mv = new MovieTicket();
            try
            {
                mv.Movie();
            }
            catch(TicketLimitException te)
            {
                Console.WriteLine(te.Message);
            }
            
        }
    }
}
