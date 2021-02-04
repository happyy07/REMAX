using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFinal
{
    class clsListHouse
    {
        // declaration of private or hidden dictionary to store the goup of houses
        private Dictionary<string, clsHouse> myList;

        public clsListHouse()
        {
            myList = new Dictionary<string, clsHouse>();
        }

        public Dictionary<string, clsHouse>.ValueCollection Elements
        {
            get => myList.Values;
        }

        public int Quantity
        {
            get => myList.Count;
        }

        public bool Add(clsHouse house)
        {
            if (Exist(house.HouseNumber) == false)
            {
                myList.Add(house.HouseNumber, house);
                return true;
            }
            else { return false; }
        }

        public bool Delete(string houseNumber)
        {
            return myList.Remove(houseNumber);
        }

        public string Display()
        {
            string info = "\n --- Houses --- \n";
            foreach (clsHouse itm in myList.Values)
            {
                info += itm.Display() + "\n";
            }
            return info;
        }

        public bool Exist(string houseNumber)
        {
            return myList.ContainsKey(houseNumber);
        }

        public clsHouse Find(string houseNumber)
        {
            if (Exist(houseNumber) == true)
            {
                return myList[houseNumber];
            }
            else { return null; }
        }
    }
}
