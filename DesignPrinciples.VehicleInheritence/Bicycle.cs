namespace DesignPrinciples.VechileInheritence
{
    public class Bicycle : Vehicle
    {
        private string _brand;
        private decimal _maxSpeed;
        private decimal _price;
        private int _gears;
        private bool _hasBasket;

        public Bicycle()
        {
            _brand = "Toyota";
            _maxSpeed = 20m;
            _gears = 2;
            _price = 150.9m;
            _hasBasket = true;
        }
        //public Bicycle(string brand, decimal maxSpeed, int gears, bool hasBasket)
        //{
        //    _brand = brand;
        //    _maxSpeed = maxSpeed;
        //    _gears = gears;
        //    _hasBasket = hasBasket;
        //}

        public override string Brand => _brand;
        public override decimal MaxSpeed => _maxSpeed;

        public override string ToString()
        {
            return $"\n==========================================\nYour Order is (Bicycle), and its features:\n\t- Brand: {this.Brand}\n\t- MaxSpeed: {this.MaxSpeed}\n\t- #Gears: {this._gears}\n\t- HasBasket: {this._hasBasket}\n\t- Total Price: ${this._price}\n==========================================\n";
        }
    }
}
