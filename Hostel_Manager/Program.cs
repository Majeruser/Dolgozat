namespace Hostel_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Guest> vendegek = new List<Guest>();
            Guest vendeg1 = new Guest("Jalen Brown", 32, false);
            Guest vendeg2 = new Guest("Kwai Leonard", 10, true);
            Guest vendeg3 = new Guest("Paul George", 17, true);
            Guest vendeg4 = new Guest("Chris Tucker", 101, false);
            vendegek.Add(vendeg1);
            vendegek.Add(vendeg2);
            vendegek.Add(vendeg3);
            vendegek.Add(vendeg4);
            vendeg1.Deposit(5000);
            vendeg2.Deposit(10000);
            vendeg3.Deposit(20000);
            Console.WriteLine(vendeg4.Deposit(100000));
            vendeg1.Stay(5);
            vendeg4.Stay(2);
            Console.WriteLine(vendeg2.Stay(0));
            Console.WriteLine(vendegek.Count());


            Hostel hostel = new Hostel("Grand Budapest", 3);
            hostel.AddGuests(vendeg1);
            hostel.AddGuests(vendeg2);
            Console.WriteLine(hostel.AddGuests(vendeg3));
            Console.WriteLine(hostel.AddGuests(vendeg4));
            
            Console.WriteLine($"{hostel.Name} -- {hostel.Capacity} -- {hostel.Guests}");
            

        }
    }
}
