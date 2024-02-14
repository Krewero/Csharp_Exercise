using Library;

public class Order
{
    private int _orderID;
    private int _customerID;
    private DateTime _orderDate;
    private DateTime _shippedDate;

    public int OrderID { get => _orderID; set => _orderID = value; }
    public int CustomerID { get => _customerID; set => _customerID = value; }
    public DateTime OrderDate { get => _orderDate; set => _orderDate = value; }
    public DateTime ShippedDate { get => _shippedDate; set => _shippedDate = value; }
}