using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Manager
{
    public class ConsoleView
    {
        public void ShowGeust(Guest guest)
        {
            Console.WriteLine(guest.GetDecription());
        }
        public void ShowGuests(List<Guest> guests)
        {
            foreach (Guest item in guests)
            {
                Console.WriteLine(item.GetDecription());
            }
        }
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
