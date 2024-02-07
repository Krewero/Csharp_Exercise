namespace RentalSystem
{
    public class Car
    {
        private string _make;
        private string _model;
        private decimal _rentalPrice;
        private bool _rented;

        public string Make 
        {
            get {return _make;}
            set
            {
                if(value == "Toyota"||value == "FIAT"||value == "Citroen"||value == "Nissan")
                {
                    _make = value;
                }
                else
                {
                    Console.WriteLine("We don't rent this car make");
                }
            }
        }

        public string Model 
        {
            get {return _model;}
            set
            {
                if(value == "Corolla"||value == "Panda"||value == "C4"||value == "Micra")
                {
                    _model = value;
                }
                else
                {
                    Console.WriteLine("We don't rent this car model");
                }
            }
        }

        public decimal RentalPrice 
        {
            get {return _rentalPrice;}
            set
            {
                if(value > 0)
                {
                    _rentalPrice = value;
                }
                else
                {
                    Console.WriteLine("This price is not available");
                }
            }
        }

        public  bool Rented 
        {
            get {return _rented;}
            set {_rented = value;}
        }

        public Car(string make, string model, decimal rentalPrice)
        {
            this.Make = make;
            this.Model = model;
            this.RentalPrice = rentalPrice;
        }

        public bool Rent()
        {
            if(this.Rented == false)
            {
                this.Rented = true;
                Console.WriteLine($"Rented the {this.Make} {this.Model} for {this.RentalPrice}/day");
                return true;
            }
            else
            {
                Console.WriteLine($"Impossible to rent this car");
                return false;
            }
        }

        public bool Return()
        {
            if(this.Rented == true)
            {
                this.Rented = false;
                Console.WriteLine($"Returned the {this.Make} {this.Model}");
                return true;
            }
            else
            {
                Console.WriteLine("This car is not acctually rent");
                return false;
            }
        }

        public string PrintInfo()
        {
            string print = $"{this.Make} {this.Model} (Rental price: {this.RentalPrice}/day) - ";
            if(this.Rented == true)
            {
                return print + "Rented";
            }
            else
            {
                return print + "Available";
            }
        }
    }
}