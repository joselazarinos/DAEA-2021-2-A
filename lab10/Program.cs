using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwndDataContext context = new NorthwndDataContext();

            // var query = from p in context.Products
            //where p.Categories.CategoryName == "Beverages"
            //           where p.UnitPrice < 20
            //         select p;
            Products p = new Products();
            p.ProductName = "Peruvian Coffe";
            p.SupplierID = 20;
            p.CategoryID = 1;
            p.QuantityPerUnit = "10pkgs";
            p.UnitPrice = 25;

            context.Products.InsertOnSubmit(p);
            context.SubmitChanges();


            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod.ProductID, prod.UnitPrice,prod.ProducName);
            }
            Console.ReadKey();

            NorthwndDataContext context = new NorthwndDataContext();
            var product = (from p in context.Products
                           where p.ProductName == "Tofu"
                           select p).FirstOrDefault();

            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;

            context.SubmitChanges();
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod.ProductID, prod.UnitPrice, prod.ProducName);
            }
            Console.ReadKey();

            NorthwndDataContext context = new NorthwndDataContext();
            var product = (from p in context.Products
                           where p.ProductID == 78
                           select p).FirstOrDefault();
            context.Products.DeleteOnSubmit(product);
            context.SubmitChanges();
        }
    }
}
