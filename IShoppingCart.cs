using System;

public interface IShoppingCart
{
    void CalculateTotal();
    void CalculateSubTotal()
    {
        Console.WriteLine("This is the IShopping cart impementation of better shoppig cart");
    }
}

public class ShoppingCart : IShoppingCart
{
    public void CalculateTotal()
    {
        Console.WriteLine("This is calculae tota in Btter shopping car");
    }
}