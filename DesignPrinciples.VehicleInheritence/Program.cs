using DesignPrinciples.VechileInheritence;

namespace DesignPrinciples.Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = ChooseVehicle();
            switch (choice)
            {
                case 1:
                    Console.WriteLine(new Car());
                    break;
                case 2:
                    Console.WriteLine(new Bicycle());
                    break;
            }

            Console.ReadKey();
        }

        static int ChooseVehicle()
        {
            Console.WriteLine("\t==========================\n\tWELCOME TO VEHICLES SYSTEM\n\t==========================\n" +
                "Choose a Vehicle: \n1) Car\n2) Bicycle\n--------------\n");
            int choice = int.Parse(Console.ReadLine());
            if(choice <= 0 && choice > 2) choice = 1;
            return choice;
        }
    }
}
