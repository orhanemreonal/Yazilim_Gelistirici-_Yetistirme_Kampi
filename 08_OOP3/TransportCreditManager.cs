using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_OOP3
{
    internal class TransportCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
