namespace DesignPrinciples.EncapsulateWhatVaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Same Result, but different design
            //Before();
            After();

            Console.ReadKey();
        }

        static void Before()
        {
            Before.Pizza pizza = new Before.Pizza();
            Before.Pizza order = pizza.Order(PizzaTypes.VEG);
            Console.WriteLine(order);
        }

        static void After()
        {
            After.Pizza pizza = new After.Pizza();
            After.Pizza order = pizza.Order(PizzaTypes.VEG);
            Console.WriteLine(order);
        }
    }
}
