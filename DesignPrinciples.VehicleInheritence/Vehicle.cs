namespace DesignPrinciples.VechileInheritence
{
    public class Vehicle
    {
        public virtual string Brand { get; } = "BMW";
        public virtual decimal MaxSpeed { get; } = 30m;
        public virtual decimal Price { get; } = 100m;
    }
}
