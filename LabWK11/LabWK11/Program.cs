using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWK11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            Console.WriteLine ("entry 2 is " + Names[2]);
            Console.WriteLine("entry 4 is " + Names[4]);

            string[] Months = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int MonthCount = 0;
            while (MonthCount <= 11)
            {
                Console.WriteLine("the month is " + Months[MonthCount] + " and its number is " + MonthCount);
                MonthCount++;
            }
            string[] Seasons = { "Spring", "Summer", "Fall", "Winter" };
            int SeasonCount = 0;
            Console.WriteLine("The Four Seasons are: ");
            while (SeasonCount <= 3)
            {
                Console.WriteLine(Seasons[SeasonCount]);
                SeasonCount++;
            }

            int[] RandomNum = new int[1000];
            Random random = new Random();
            int RandomOOF;

            RandomOOF = random.Next(0, 1000);
            for (int a = 0; a < RandomNum.Length; a++)
            {
                RandomNum[a] = random.Next(0, 1000);
            }

            foreach (int z in RandomNum)
            {
                Console.WriteLine(z.ToString());
            }

            Console.ReadLine();
        }
    }
}
