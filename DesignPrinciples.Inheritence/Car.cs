namespace DesignPrinciples.VechileInheritence
{
    public class Car: Vehicle
    {
        private string _brand;
        private decimal _maxSpeed;
        private decimal _price;
        private int _doors;
        private bool _automaticTransmission;

        public Car()
        {
            _brand = "Toyota";
            _maxSpeed = 50m;
            _doors = 4;
            _price = 599.9m;
            _automaticTransmission = false;
        }
        //public Car(string brand, decimal maxSpeed, int doors, bool automatic)
        //{
        //    _brand = brand;
        //    _maxSpeed = maxSpeed;
        //    _doors = doors;
        //    _automaticTransmission = automatic;
        //}

        public override string Brand => _brand;
        public override decimal MaxSpeed => _maxSpeed;
        public override decimal Price => base.Price + _price;

        public override string ToString()
        {
            return $"\n==========================================\nYour Order is (Car), and its features:\n\t- Brand: {this.Brand}\n\t- MaxSpeed: {this.MaxSpeed}\n\t- #Doors: {this._doors}\n\t- IsAutomatic: {this._automaticTransmission}\n\t- Total Price: ${this._price}\n==========================================\n";
        }
    }
}
