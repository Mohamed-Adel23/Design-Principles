namespace DesignPrinciples.VechileInheritence
{
    public class Vehicle
    {
        public virtual string Brand { get; } = "BMW";
        public virtual decimal MaxSpeed { get; } = 30m;
        public virtual decimal Price { get; } = 100m;

        public List<IVComponent> vComponents { get; } = new List<IVComponent>();
        public void AddVComponent(IVComponent vComponent)
        {
            if(vComponents.FirstOrDefault(x => x.Name == vComponent.Name) !=  null)
            {
                Console.WriteLine("Oops, This Component had been chosen before!!");
                System.Threading.Thread.Sleep(3000);
            }
            else
                vComponents.Add(vComponent);
        }

        public decimal CalcPrice()
        {
            decimal total = this.Price;
            foreach(IVComponent vComponent in vComponents)
            {
                total += vComponent.Price;
            }
            return total;
        }

        public override string ToString()
        {
            if (vComponents.Count <= 0) return "\n\tNO CHOICES :(";
            string output = "\n------------------------\nYour Vehicle Components:\n------------------------\n";
            foreach(IVComponent vComponent in vComponents)
            {
                output += "\t" + vComponent.Name + "\n";
            }
            output += $"\n==> Base Price: ${this.Price} || Total Price: ${CalcPrice()} <==\n-------------------------------------------------\n";
            return output;
        }
    }
}
