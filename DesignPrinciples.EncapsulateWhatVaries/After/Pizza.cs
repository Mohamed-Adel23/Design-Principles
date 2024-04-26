namespace DesignPrinciples.EncapsulateWhatVaries.After
{
    public class Pizza
    {
        public virtual string Title => $"{nameof(Pizza)}";
        public virtual decimal Price => 10m;

        public Pizza Order(PizzaTypes type)
        {
            // Now, We encapsulate what varies
            Pizza pizza = Create(type);

            Prepare();
            Cook();
            Cut();

            return pizza;
        }

        // This is a variable code
        private static Pizza Create(PizzaTypes type)
        {
            switch (type)
            {
                case PizzaTypes.CHE:
                    return new Cheese();
                case PizzaTypes.CHI:
                    return new Chicken();
                case PizzaTypes.VEG:
                    return new Vegeterian();
                default:
                    return new Cheese();
            }
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
