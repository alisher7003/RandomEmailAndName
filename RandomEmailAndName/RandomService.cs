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
        public static void RandomCountries(int count)
        {
            CountryName countryName = new CountryName();
            for (int i = 0; i < count; i++)
            {
                string country = countryName.GetValue();
                Console.WriteLine(country);
            }
        }
        public static void RandomParagraphs(int count)
        {
            Lipsum lipsum = new Lipsum(LipsumFlavor.ChildHarold, 3, 10, 10, 20, count);
            string randomWords = lipsum.GetValue();
            Console.WriteLine(randomWords);
        }
        public static void CreateRandomFullName(int count)
        {
            RealNames realNames = new RealNames();
            for (int i = 0; i < count; i++)
            {
                string randomFullName = realNames.GetValue();
                Console.WriteLine(randomFullName);
            }
        }
        public static void GenerateEmailAddress(int count)
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
