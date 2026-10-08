using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Manager
{
    public class Guest
    {
        private string _name;
        private int _age;
        private bool _isStudent;
        private static int _count;
        private int _balance;
        private int _nigthStayed;

        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age >= 16 && _age <= 90 ? _age : 0; } set { _age = value; } }
        public static int Count { get; }
        public int Balance { get; }
        public int NigthStayed { get; }


        public bool IsStudent { get { return _isStudent; } set { _isStudent = value; } }
        public Guest(string name, int age, bool isstudent)
        {
            name = _name;
            age = _age;
            isstudent = _isStudent;
            _count++;
        }
        public bool Deposit(int amount)
        {
            if (amount == 5000 || amount == 10000 || amount == 20000)
            {
                _balance += amount;
                return true;
            }
            {
                return false;
            }
        }
        public bool Stay(int nights)
        {
            int valami = _isStudent ? 4000 : 6000;

            if (nights >= 1 && _balance > nights * valami)
            {
                _balance -= nights * valami;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetDecription()
        {
            string valami = "";
            if (_age == 0)
            {
                valami = "ismeretlen kor";
            }
            else
            {
                valami = $"{_age}";

            }
            string valami2 = _isStudent ? "diák" : "Teljes"; 
            return $"{_name} -- ({valami}, {valami2}) -- {_balance}ft -- {_nigthStayed} ";
        }
        public void FindByName(string name)
        {

        }

    }
}
