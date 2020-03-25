using System;

namespace Composite
{
    public class Program
    {
        static void Main(string[] args)
        {
            Boxs complexOrder = new Boxs();

            Products receipt = new Products("Receipt");
            complexOrder.Add(receipt);

            Boxs phoneBox = new Boxs();
            phoneBox.Add(new Products("Phone"));
            phoneBox.Add(new Products("HeadPhones"));

            Boxs chargerBox = new Boxs();
            chargerBox.Add(new Products("Charger"));

            complexOrder.Add(phoneBox);
            complexOrder.Add(chargerBox);


            Console.WriteLine($"RESULT: {complexOrder.Operation()}\n");

        }
    }
}