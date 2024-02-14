using Library;

public class OrderDetail
{
    private int _orderDetailID;
    private int _orderID;
    private int _productID;
    private int _quantity;
    private decimal _discount;

    public int OrderDetailID { get => _orderDetailID; set => _orderDetailID = value; }
    public int OrderID { get => _orderID; set => _orderID = value; }
    public int ProductID { get => _productID; set => _productID = value; }
    public int Quantity { get => _quantity; set => _quantity = value; }
    public decimal Discount { get => _discount; set => _discount = value; }


}