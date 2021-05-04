using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using LABNET2021_TP_LQ_ENTITIES;

namespace LABNET2021_TP_LQ_LOGIC
{
    public class ProductsLogic : BaseLogic, Interface1<Products>
    {
        public List<Products> Getall()
        {
            return context.Products.ToList();
        }

        public List<Products> query2 ()
        {
            var query = from products in context.Products
                        where products.UnitsInStock == 0
                        select products;

            return query.ToList();
                    

        }

        public List<Products> query3()
        {
            var query = from products in context.Products
                        where products.UnitsInStock != 0 && products.UnitPrice>3
                        select products;

            return query.ToList();


        }


    }
}
