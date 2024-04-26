namespace DesignPrinciples.EncapsulateWhatVaries.After
{
    public class Chicken : Pizza
    {
        public override string Title => base.Title + nameof(Chicken);
        public override decimal Price => base.Price + 29.99m;
    }
}
