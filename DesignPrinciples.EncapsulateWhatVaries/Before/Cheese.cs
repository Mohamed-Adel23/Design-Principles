namespace DesignPrinciples.EncapsulateWhatVaries.Before
{
    public class Cheese : Pizza
    {
        public override string Title => base.Title + nameof(Cheese);
        public override decimal Price => base.Price + 13.5m;
    }
}
