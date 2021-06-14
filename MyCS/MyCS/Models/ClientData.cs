using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCS.Models
{
    public class ClientData
    {
        [Index(0)]
        public long Account_Number { get; set; }

        [Index(1)]
        public string Account_Type { get; set; } = "";

        [Index(2)]

        public string Final_Decision { get; set; } = "";

        [Index(3)]
        public long Current_Delinquency_status { get; set; }

        [Index(4)]
        public long Application_Date { get; set; }

        [Index(5)]

        public long Application_Score { get; set; }

        [Index(6)]
        public string Cheque_Card_Flag { get; set; } = "";

        [Index(7)]
        public string Existing_Customer_Flag { get; set; } = "";

        [Index(8)]

        public long Gross_Annual_Income { get; set; }

        [Index(9)]
        public string Home_Telephone_Number { get; set; } = "";

        [Index(10)]
        public string Insurance_Required { get; set; } = "";

        [Index(11)]

        public long Loan_Amount { get; set; }

        [Index(12)]
        public string Loan_Payment_Frequency { get; set; } = "";

        [Index(13)]
        public string Loan_Payment_Method { get; set; } = "";

        [Index(14)]

        public string Marital_Status { get; set; } = "";

        [Index(15)]
        public long Number_of_Dependants { get; set; }

        [Index(16)]
        public int Number_of_Payments { get; set; }

        [Index(17)]

        public string Occupation_Code { get; set; } = "";

        [Index(18)]
        public string Promotion_Type { get; set; } = "";

        [Index(19)]

        public string Residential_Status { get; set; } = "";

        [Index(20)]
        public long Time_at_Address { get; set; } 

        [Index(21)]
        public long Time_in_Employment { get; set; }

        [Index(22)]

        public long Time_with_Bank { get; set; }

        [Index(23)]
        public decimal Weight_Factor { get; set; } 

        [Index(24)]
        public string GB_Flag { get; set; } = "";

        [Index(25)]

        public long Age_of_Applicant { get; set; }

        [Index(26)]
        public long Application_Month { get; set; }

        [Index(27)]
        public long Bureau_Score { get; set; }

        [Index(28)]

        public long SP_ER_Reference { get; set; }

        [Index(29)]

        public long SP_Number_Of_Searches_L6M { get; set; }

        [Index(30)]
        public long SP_Number_of_CCJs { get; set; }

        [Index(31)]
        public decimal loan_to_income { get; set; }

        [Index(32)]

        public string split { get; set; } = "";





    }
}
