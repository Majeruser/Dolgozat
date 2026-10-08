using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Manager
{
    public class Hostel
    {
        private string _name;
        private int _capacity;
        private List<Guest> _guests;
        public string Name { get {return _name; } set { _name = value; } }
        public int Capacity { get; }
        public List<Guest> Guests { get;}
        public Hostel(string name, int capacity)
        {
            name = _name;
            capacity = _capacity;
            _guests = new List<Guest>();
        }
        public bool AddGuests(Guest guest)
        {
            if (_capacity >= _guests.Count())
            {
                _guests.Add(guest);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Guest FindByName(string name)
        {
            foreach (var item in _guests)
            {
                if(item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
        public bool Checkout(string name)
        {
            if(_guests.FindByName(name) == true)
            {
                _guests.Remove();
                return true;
            }
        }
    }
}
