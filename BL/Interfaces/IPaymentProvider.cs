using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public class IPaymentProvider
    {
        string Name { get; set; }
        int Id { get; set; }
        int AccountNumber { get; set; }
        double Interest { get; set; }

        static string GetProviderID()
        {
            return "";
        }
    }
}
