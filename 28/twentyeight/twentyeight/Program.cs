using System.Linq.Expressions;
using twentyeight;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer("Dan", "dlosevdan@gmail.com", "+7-123-456-789");

        Order order = new Order();

        customer.SubscribeToOrder(order);

        order.AddGoods(new Goods("Notebook", 1000));
        order.AddGoods(new Goods("Pen", 2));
        order.AddGoods(new Goods("Notebook", 1000));
        order.RemoveGoods(new Goods("Pen", 2));

        order.CountGoods();
    }
}