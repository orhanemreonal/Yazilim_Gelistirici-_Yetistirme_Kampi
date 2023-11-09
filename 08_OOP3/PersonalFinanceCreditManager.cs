using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_OOP3
{
    internal class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
