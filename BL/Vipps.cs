
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;

namespace BL
{
    public class Vipps : IPaymentProvider
    {
        double Interest { get; set; }
        public Vipps()
        {
            Interest = 4.0d;
        }
        public static string GetProviderID()
        {
            return "VIPPS";
        }
    }
}
