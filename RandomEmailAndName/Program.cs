namespace RandomEmailAndName
{
    internal class Program
    {
        static void Main(string[] args)
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
                        RandomService.RandomParagraphs(count: setNumber);
                        break;
                    case 2:
                        RandomService.RandomCountries(count: setNumber);
                        break;
                    case 3:
                        RandomService.CreateRandomFullName(count: setNumber);
                        break;
                    case 4:
                        RandomService.GenerateEmailAddress(count: setNumber);
                        break;
                }
                Console.WriteLine("Do you want to continue? press \"yes\" or any button");
                inputString = Console.ReadLine().ToLower();
            } while (inputString == "yes");
        }
    }
}
