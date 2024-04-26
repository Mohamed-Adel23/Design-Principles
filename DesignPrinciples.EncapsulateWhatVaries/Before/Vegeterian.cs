namespace DesignPrinciples.EncapsulateWhatVaries.Before
{
    public class Vegeterian : Pizza
    {
        public override string Title => base.Title + nameof(Vegeterian);
        public override decimal Price => base.Price + 18.5m;
    }
}
