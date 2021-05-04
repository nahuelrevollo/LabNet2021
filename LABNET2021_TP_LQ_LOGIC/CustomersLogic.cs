using LABNET2021_TP_LQ_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LABNET2021_TP_LQ_LOGIC
{
    public class CustomersLogic : BaseLogic, Interface1<Customers>
    {
        public List<Customers> Getall()
        {
            return context.Customers.ToList();
        }


        public List<Customers> query4()
        {
            var query = from customers in context.Customers
                        where customers.City== "Washington"
                        select customers;

            return query.ToList();


        }

        public List<Customers> query6()
        {
            var query = from customers in context.Customers                       
                        select customers;

            return query.ToList();


        }

        public List<Customers> query7()
        {
            var query = from customers in context.Customers
                        join orders in context.Orders
                        on new { customers.CustomerID }
                        equals new { CustomerID = orders.CustomerID}
                        select new
                        { 
                            customers.CustomerID,
                            customers.ContactName
                        
                        };

            // no entiendo porque rompe aca

            return query.ToList();


        }

    }
}
