using LABNET2021_TP_LQ_ENTITIES;
using LABNET2021_TP_LQ_LOGIC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNET2021_TP_LINKQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Query para devolver objeto customer

            IEnumerable<Customers> Listado_Customers = new List<Customers>();

            CustomersLogic customersLogic = new CustomersLogic();

            Listado_Customers = customersLogic.Getall();


            var queryPunto1 = Listado_Customers.Where(c => c.CustomerID == "ALFKI");

            foreach (var item in queryPunto1)
            {
                Console.WriteLine($"{item.CustomerID}-{item.CompanyName}-{item.ContactName}");
            }

            Console.ReadLine();

            //2. Query para devolver todos los productos sin stock

            IEnumerable<Products> Listado_products = new List<Products>();

            ProductsLogic productsLogic = new ProductsLogic();

           
            var queryPunto2 = productsLogic.query2();

           

            foreach (var item in queryPunto2)
            {
                Console.WriteLine($"{item.ProductID}-{item.ProductName}-{item.UnitsInStock}");
            }

            Console.ReadLine();

            //3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad

            var queryPunto3 = productsLogic.query3();

            foreach (var item in queryPunto3)
            {
                Console.WriteLine($"{item.ProductID}-{item.ProductName}-{item.UnitsInStock}-{item.UnitPrice}");
            }

            Console.ReadLine();

            //4. Query para devolver todos los customers de Washington


            var queryPunto4 = customersLogic.query4();

            if (queryPunto4 == null)
            {

                Console.WriteLine("No hay customers de Washington");
            }

            else {

                foreach (var item in queryPunto4)
                {
                    Console.WriteLine($"{item.CustomerID}-{item.CompanyName}-{item.City}-{item.Country}");
                }
            }

            Console.ReadLine();

            // 5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de
            //producto sea igual a 789

            Listado_products = productsLogic.Getall();


            var queryPunto5 = Listado_products.Where(p => p.ProductID == 789);

            foreach (var item in queryPunto5)
            {
                Console.WriteLine($"{item.ProductID}-{item.ProductName}");
            }

            Console.ReadLine();

            //6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.

            var queryPunto6 = customersLogic.query6();

            foreach (var item in queryPunto6)
            {
                Console.WriteLine($"{item.CustomerID}-{item.ContactName.ToLower()}-{item.ContactName.ToUpper()}");
            }
            

            Console.ReadLine();


            //7. Query para devolver Join entre Customers y Orders donde los customers sean de
            //Washington y la fecha de orden sea mayor a 1 / 1 / 1997.

            var queryPunto7 = customersLogic.query7();

            foreach (var item in queryPunto7)
            {
                Console.WriteLine($"{item.CustomerID}-{item.ContactName}");
            }


            Console.ReadLine();

           


        }
    }
}
