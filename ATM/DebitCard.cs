namespace DBT
{
    public class DebitCard
    {
        private string _pin;

        public string Pin 
        {
            get {return _pin;}
            set
            {
                if(value.Length >= 4 && value.Length <= 6)
                {
                    _pin = value;
                    Console.WriteLine($"The pin is valid:{value}");
                }
                else
                {
                    Console.WriteLine("The pin is invalid");
                }
            }
        }
    }
}