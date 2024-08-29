using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q9
    {
        static List<Item> cart = new List<Item>();
        public static void q9()
        {
            while (true)
            {
                Console.WriteLine("Shopping Cart System");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. View cart");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        RemoveItem();
                        break;
                    case 3:
                        ViewCart();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddItem()
        {
            Console.Write("Enter item name: ");
            string name = Console.ReadLine();
            Console.Write("Enter item price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Item item = new Item(name, price);
            cart.Add(item);
            Console.WriteLine("Item added to cart.");
        }

        static void RemoveItem()
        {
            Console.Write("Enter item name to remove: ");
            string name = Console.ReadLine();

            Item itemToRemove = cart.Find(i => i.Name == name);
            if (itemToRemove != null)
            {
                cart.Remove(itemToRemove);
                Console.WriteLine("Item removed from cart.");
            }
            else
            {
                Console.WriteLine("Item not found in cart.");
            }
        }

        static void ViewCart()
        {
            Console.WriteLine("Shopping Cart:");
            decimal totalPrice = 0;

            foreach (Item item in cart)
            {
                Console.WriteLine($"{item.Name}: {item.Price:C}");
                totalPrice += item.Price;
            }

            Console.WriteLine($"Total price: {totalPrice:C}");
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
