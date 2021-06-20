using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace experian.Controllers
{
    public class ManualDataController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Index(string Account_Number, string Account_Type, string Final_Decision, string Current_Delinquency_status, string Application_Date, string Application_Score, string Cheque_Card_Flag, string Existing_Customer_Flag, string Gross_Annual_Income, string Home_Telephone_Number, string Insurance_Required, string Loan_Amount, string Loan_Payment_Frequency, string Loan_Payment_Method, string Marital_Status, string Number_of_Dependants, string Number_of_Payments, string Occupation_Code, string Promotion_Type, string Residential_Status, string Time_at_Address, string Time_in_Employment, string Time_with_Bank, string Weight_Factor, string GB_Flag, string Age_of_Applicant, string Application_Month, string Bureau_Score, string SP_ER_Reference, string SP_Number_Of_Searches_L6M, string SP_Number_of_CCJs, string loan_to_income, string split)
        {
            List<string> data = new List<string>();
            data.Add(Account_Number);
            data.Add(Account_Type);
            data.Add(Final_Decision);
            data.Add(Current_Delinquency_status);
            data.Add(Application_Date);
            data.Add(Application_Score);
            data.Add(Cheque_Card_Flag);
            data.Add(Existing_Customer_Flag);
            data.Add(Gross_Annual_Income);
            data.Add(Home_Telephone_Number);
            data.Add(Insurance_Required);
            data.Add(Loan_Amount);
            data.Add(Loan_Payment_Frequency);
            data.Add(Loan_Payment_Method);
            data.Add(Number_of_Dependants);
            data.Add(Number_of_Payments);
            data.Add(Occupation_Code);
            data.Add(Promotion_Type);
            data.Add(Residential_Status);
            data.Add(Time_at_Address);
            data.Add(Time_in_Employment);
            data.Add(Time_with_Bank);
            data.Add(Weight_Factor);
            data.Add(GB_Flag);
            data.Add(Age_of_Applicant);
            data.Add(Application_Month);
            data.Add(Bureau_Score);
            data.Add(SP_ER_Reference);
            data.Add(SP_Number_Of_Searches_L6M);
            data.Add(SP_Number_of_CCJs);
            data.Add(loan_to_income);
            data.Add(split);

            Console.WriteLine();
            return View("Success");
        }

    }
}
