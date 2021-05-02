using LABNET2021_TP_EF_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNET2021_TP_EF_LOGIC
{
    public class ProductsLogic:BaseLogic
    {

        public List<Products> GetAll()
        {

            return context.Products.ToList();
        }

        public void Add(Products Nuevoproducto)
        {

            context.Products.Add(Nuevoproducto);

            context.SaveChanges();

        }

        public void Delete(int Id)
        {

            var productoAborra = context.Products.First(p => p.ProductID == Id);

            context.Products.Remove(productoAborra);

            context.SaveChanges();


        }


        public void Update(Products Modificoproducto)
        {
            var productoAmodificar = context.Products.First(p => p.ProductID == Modificoproducto.ProductID);

            productoAmodificar.ProductName = Modificoproducto.ProductName;

            context.SaveChanges();

        }

    }
}
