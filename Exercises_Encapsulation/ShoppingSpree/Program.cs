using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            var allPeople = Console.ReadLine().Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
            var allProducts = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var pair in allPeople)
                {
                    var personInfo = pair.Split('=');
                    Person person = new Person(personInfo[0], decimal.Parse(personInfo[1]));
                    people.Add(person);
                }
                foreach (var pair in allProducts)
                {
                    var productInfo = pair.Split('=');
                    Product product = new Product(productInfo[0],decimal.Parse(productInfo[1]));
                    products.Add(product);
                }

                string purchase;
                while ((purchase = Console.ReadLine())!= "END")
                {
                    var tokens = purchase.Split();
                    var buyerName = tokens[0];
                    var prod = tokens[1];

                    var buyer = people.FirstOrDefault(p => p.Name == buyerName);
                    var productToBuy = products.FirstOrDefault(p => p.Name == prod);
                    try
                    {
                        buyer.BuyProduct(productToBuy);
                        Console.WriteLine($"{buyer.Name} bought {prod}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                foreach (var person in people)
                {
                    var boughtProduct = person.GetProducts();
                    var result = boughtProduct.Any()
                        ? string.Join(", ", boughtProduct.Select(p => p.Name).ToList())
                        : "Nothing bought";
                    Console.WriteLine($"{person.Name} - {result}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
