using DesignPrinciples.VechileInheritence;

namespace DesignPrinciples.VehicleComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = ChooseComponent();
            Vehicle vehicle = new Vehicle();
            while(choice >= 1 && choice <= 4)
            {
                IVComponent vComponent = null;
                switch (choice)
                {
                    case 1:
                        vComponent = new Door(); break;
                    case 2:
                        vComponent = new AutomaticTransmission(); break;
                    case 3:
                        vComponent = new Gear(); break;
                    case 4:
                        vComponent = new Basket(); break;
                    default:
                        break;
                }
                vehicle.AddVComponent(vComponent);
                Console.Clear();
                choice = ChooseComponent();
            }
            Console.WriteLine(vehicle);

            Console.WriteLine("\n\t >>>> THANKS <<<<");

            Console.ReadKey();
        }

        static int ChooseComponent()
        {
            Console.WriteLine("\t==========================\n\tWELCOME TO VEHICLES SYSTEM\n\t==========================\n" +
                "Choose a Component: \n1) Door\n2) AutomaticTransmission\n3) Gear\n4) Basket\n(Press any Key to exit)\n--------------\n");
            int choice;
            if(int.TryParse(Console.ReadLine(), out choice)) return choice;
            return -1;
        }
    }
}
