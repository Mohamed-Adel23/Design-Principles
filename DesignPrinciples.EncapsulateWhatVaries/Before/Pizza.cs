namespace DesignPrinciples.EncapsulateWhatVaries.Before
{
    public class Pizza
    {
        public virtual string Title => $"{nameof(Pizza)}";
        public virtual decimal Price => 10m;

        public Pizza Order(PizzaTypes type)
        {
            Pizza pizza;
            // -- variable Code --
            // We should encapsulate this code
            switch (type)
            {
                case PizzaTypes.CHE:
                    pizza = new Cheese();
                    break;
                case PizzaTypes.CHI:
                    pizza = new Chicken();
                    break;
                case PizzaTypes.VEG:
                    pizza = new Vegeterian();
                    break;
                default:
                    pizza = new Cheese();
                    break;
            }
            // -- Constant Code --
            Prepare();
            Cook();
            Cut();
            return pizza;
        }

        private static void Prepare()
        {
            Console.Write("preparing...");
            Thread.Sleep(500);
            Console.WriteLine(" completed");
        }

        private static void Cook()
        {
            Console.Write("cooking...");
            Thread.Sleep(500);
            Console.WriteLine(" completed");
        }

        private static void Cut()
        {
            Console.Write("cutting and boxing...");
            Thread.Sleep(500);
            Console.WriteLine(" completed");
        }

        public override string ToString()
        {
            return $"\n{Title}" +
                   $"\n\tPrice: {Price.ToString("C")}";
        }
    }
}
