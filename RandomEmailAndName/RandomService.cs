using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tynamix.ObjectFiller;

namespace RandomEmailAndName
{
    internal class RandomService
    {
        public static void GetMenu()
        {
            int selection;
            string inputString;
            do
            {
                Console.Write("Menu \n1->Random Paragraph\n2->Random Country\n3->Random FullName\n4->Random Email address\nSelect: ");
                selection = int.Parse(Console.ReadLine());
                Console.Write("how many random repeats you want: ");
                int setNumber;
                setNumber = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        RandomParagraphs(count: setNumber);
                        break;
                    case 2:
                        RandomCountries(count: setNumber);
                        break;
                    case 3:
                        CreateRandomFullName(count: setNumber);
                        break;
                    case 4:
                        GenerateEmailAddress(count: setNumber);
                        break;
                }
                Console.WriteLine("Do you want to continue? press \"yes\" or any button");
                inputString = Console.ReadLine().ToLower();
            } while (inputString == "yes");
        }

        private static void RandomCountries(int count)
        {
            CountryName countryName = new CountryName();
            for (int i = 0; i < count; i++)
            {
                string country = countryName.GetValue();
                Console.WriteLine(country);
            }
        }
        private static void RandomParagraphs(int count)
        {
            Lipsum lipsum = new Lipsum(LipsumFlavor.ChildHarold, 3, 10, 10, 20, count);
            string randomWords = lipsum.GetValue();
            Console.WriteLine(randomWords);
        }
        private static void CreateRandomFullName(int count)
        {
            RealNames realNames = new RealNames();
            for (int i = 0; i < count; i++)
            {
                string randomFullName = realNames.GetValue();
                Console.WriteLine(randomFullName);
            }
        }
        private static void GenerateEmailAddress(int count)
        {
            EmailAddresses emailGenerator = new EmailAddresses();
            for (int i = 0; i < count; i++)
            {
                string emailRandom = emailGenerator.GetValue();
                Console.WriteLine(emailRandom);
            }
        }
    }
}
