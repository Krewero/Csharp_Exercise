namespace Library
{
    public class Customer
    {
        private int _customerID;
        private string _firstName;
        private string _lastName;
        private string _country;

        public int CustomerID { get => _customerID; set => _customerID = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Country { get => _country; set => _country = value; }
    }
}