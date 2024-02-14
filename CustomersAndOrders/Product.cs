using Library;

public class Product
{
    private int _productID;
    private string _productName;
    private decimal _unitPrice;

    public int ProductID { get => _productID; set => _productID = value; }
    public string ProductName { get => _productName; set => _productName = value; }
    public decimal UnitPrice { get => _unitPrice; set => _unitPrice = value; }
}