using _08_OOP3;
using System.Collections.Generic;

//PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
//personalFinanceCreditManager.Calculate();

//TransportCreditManager transportCreditManager = new TransportCreditManager();
//transportCreditManager.Calculate();

//MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
//mortgageLoanManager.Calculate();

//------------------------------------//

//ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
//personalFinanceCreditManager.Calculate();

//ICreditManager transportCreditManager = new TransportCreditManager();
//transportCreditManager.Calculate();

//ICreditManager mortgageLoanManager = new MortgageLoanManager();
//mortgageLoanManager.Calculate();

//------------------------------------//

ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
ICreditManager transportCreditManager = new TransportCreditManager();
ICreditManager mortgageLoanManager = new MortgageLoanManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService filelLoggerService = new FileLoggerService();

CreditApplicationManager creditApplicationManager = new CreditApplicationManager();
creditApplicationManager.Application(mortgageLoanManager, new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService()});

List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager, mortgageLoanManager,transportCreditManager };


//creditApplicationManager.DoCreditInformation(credits);

//------------------------------------//

// Interfaceleri birbirlerinin alternati olan ama...
// ...kod içerikleri farklı olan durumlar için kullanırız

