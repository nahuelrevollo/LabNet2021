using LABNET2021_TP_EF_ENTITIES;
using LABNET2021_TP_EF_LOGIC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNET2021_TP_FRAMEWORK
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductsLogic productsLogic = new ProductsLogic();

            foreach (var product in productsLogic.GetAll())
            {

                Console.WriteLine($"{product.ProductID}-{product.ProductName} -{product.Categories.CategoryID}- {product.Categories.CategoryName}");

            }

            Console.WriteLine();


            /* aca agrego un nuevo producto

            productsLogic.Add(new Products
            {

                ProductName = "Nuevo Producto",
                SupplierID = 26,
                CategoryID = 2,
                QuantityPerUnit = "40 - 100 g pkgs.",
                UnitPrice = 220,
                UnitsInStock = 1000,
                UnitsOnOrder = 7,
                ReorderLevel = 23,
                Discontinued = false,



            });*/

            /*
            Este seria el producto a eliminar

            productsLogic.Add(new Products
             {
                 
                 ProductName = "Nuevo Producto que se va a eliminar",
                 SupplierID = 26,
                 CategoryID = 2,
                 QuantityPerUnit = "40 - 100 g pkgs.",
                 UnitPrice= 220,
                 UnitsInStock=1000,
                 UnitsOnOrder=7,
                 ReorderLevel= 23,
                 Discontinued = false,



             })
                       
            
            ;*/


            //productsLogic.Delete(79);


            //aca modifico un producto ya existente

            productsLogic.Update(new Products
            {
                ProductID=78,
                ProductName = "Modifico nuevo producto"

            }); ;


            Console.WriteLine();

            foreach (var product in productsLogic.GetAll())
            {

                Console.WriteLine($"{product.ProductID}-{product.ProductName} -{product.Categories.CategoryID}- {product.Categories.CategoryName}");

            }

            Console.ReadLine();

        }
    }
}
