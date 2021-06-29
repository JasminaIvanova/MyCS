using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        public IActionResult Index(IFormCollection form)
        {
            string Account_Number = form["Account_Number"];
            string Account_Type = form["Account_Type"];
            string Final_Decision = form["Final_Decision"];
            string Current_Delinquency_status = form["Current_Delinquency_status"];
            string Application_Date = form["Application_Date"];
            string Application_Score = form["Application_Score"];
            string Cheque_Card_Flag = form["Cheque_Card_Flag"];
            string Existing_Customer_Flag = form["Existing_Customer_Flag"];
            string Gross_Annual_Income = form["Gross_Annual_Income"];
            string Home_Telephone_Number = form["Home_Telephone_Number"];
            string Insurance_Required = form["Insurance_Required"];
            string Loan_Amount = form["Loan_Amount"];
            string Loan_Payment_Frequency = form["Loan_Payment_Frequency"];
            string Loan_Payment_Method = form["Loan_Payment_Method"];
            string Marital_Status = form["Marital_Status"];
            string Number_of_Dependants = form["Number_of_Dependants"];
            string Number_of_Payments = form["Number_of_Payments"];
            string Occupation_Code = form["Occupation_Code"];
            string Promotion_Type = form["Promotion_Type"];
            string Residential_Status = form["Residential_Status"];
            string Time_at_Address = form["Time_at_Address"];
            string Time_in_Employment = form["Time_in_Employment"];
            string Time_with_Bank = form["Time_with_Bank"];
            string Weight_Factor = form["Weight_Factor"];
            string GB_Flag = form["GB_Flag"];
            string Age_of_Applicant = form["Age_of_Applicant"];
            string Application_Month = form["Application_Month"];
            string Bureau_Score = form["Bureau_Score"];
            string SP_ER_Reference = form["SP_ER_Reference"];
            string SP_Number_Of_Searches_L6M = form["SP_Number_Of_Searches_L6M"];
            string SP_Number_of_CCJs = form["SP_Number_of_CCJs"];
            string loan_to_income = form["loan_to_income"];
            string split = form["split"];

            Console.WriteLine();



            return View("Success");


        }

    }
}
