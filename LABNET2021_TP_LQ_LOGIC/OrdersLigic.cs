using LABNET2021_TP_LQ_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNET2021_TP_LQ_LOGIC
{
    public class OrdersLigic : BaseLogic, Interface1<Orders>
    {
        public List<Orders> Getall()
        {
            return context.Orders.ToList();
        }

    }
}
