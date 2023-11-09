using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_OOP3
{
    class CreditApplicationManager
    {
        //Method Injection
        public void Application(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            // 
            
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void DoCreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
