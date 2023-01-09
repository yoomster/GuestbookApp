using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    public static class ConsoleMethods
    {
        public static string GroupName()
        {
            Console.Write("Enter the group name please: ");
            string name = Console.ReadLine();

            return name;
        }

        public static double GroupSize()
        {
            Console.Write("What is the size of your group: ");
            string amountOfPeople = Console.ReadLine();
            bool validInt = double.TryParse(amountOfPeople, out double num);

            return num;
        }

        public static void AllFamilieNames(List<string> AllGuests)
        {
            foreach (var guest in AllGuests)
            {
            Console.WriteLine($"The group '{guest}' is present.");
            }
        }

        public static void FamilySizeList(List<double> familySize)
        {
            Console.WriteLine($"Total people here is: {familySize.Sum()}");
        }
    }
}
