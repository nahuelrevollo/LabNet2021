using LABNET2021_TP_LQ_DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNET2021_TP_LQ_LOGIC
{
    public class BaseLogic
    {

        protected readonly NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
