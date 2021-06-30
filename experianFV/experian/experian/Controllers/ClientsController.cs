using CsvHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.FileIO;
using experian.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace experian.Controllers
{
    public class ClientsController : Controller
    {
        
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Authorize]
        public IActionResult Index(List<List<string>> clientsData)
        {
           // clientsData = clientsData == null ? new List<List<string>>() : clientsData;
            return View(clientsData);
        }
        bool error = false;
        [HttpPost]
        [Authorize]
        public IActionResult Index(IFormFile file)
        {
            if (file == null)
            {
                error = true;
                ViewBag.Error = error;
                ViewBag.ErrorText = "Select a CSV file to upload!";
                return View("UploadError");
            }
            #region Upload CSV
            string fileName = $"{Directory.GetCurrentDirectory()}{@"\Files"}" + "\\" + file.FileName;
            string extension = fileName.Substring(fileName.Length - 3, 3);
            if (extension != "csv")
            {
                error = true;
                ViewBag.Error = error;
                ViewBag.ErrorText = "The file uploaded is not in the correct format, please upload a csv file";
                return View("UploadError");
            }
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            #endregion

            var records = this.GetClientsDataList(file.FileName);
            return Index(records);
        }

        private List<List<string>> GetClientsDataList(string fileName)
        {
            List<List<string>> records = new List<List<string>>();
            //List<ClientData> clientsData = new List<ClientData>();
            #region Read CSV
            var path = $"{Directory.GetCurrentDirectory()}{@"\Files"}";
            using (TextFieldParser csv = new TextFieldParser(path + "\\" + fileName))
            { 
                csv.SetDelimiters(new string[] { ";" });
                csv.ReadLine();

                while (!csv.EndOfData)
                {
                    try
                    {
                        string[] fields = csv.ReadFields();
                        List<string> data = fields[0].Split(",").ToList();
                        records.Add(data);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                    
                }
                Console.WriteLine();
            }
            CalculateScore(records);
            addToFile(CalculateScore(records), path + "\\result" + fileName);
            return records;
            #endregion
            
        }
        private Dictionary<long,string> CalculateScore(List<List<string>> records) 
        {
            Dictionary<long, string> finalResult = new Dictionary<long, string>();
            double existing_Customer_Flag_value = 0;
            double number_of_Dependants_value = 0;
            double occupation_Code_value = 0;
            double residential_Status_value = 0;
            double time_in_Employment_value = 0;
            double bureau_Score_value = 0;
            double sp_ER_Reference_value = 0;
            double sp_Number_Of_Searches_L6M_value = 0;
            double sp_Number_of_CCJs_value = 0;
            double value = 0;
            double score = 0;
            string result = "";
            int number;


            for (int i = 0; i < records.Count; i++)
            {
                if (records[i][7] == "")
                {
                    finalResult.Add(long.Parse(records[i][0]), "Invalid Existing Customer Flag!");
                    continue;
                }
                if (records[i][7] == "N") 
                {
                    existing_Customer_Flag_value = 0.1532;
                }
                else if(records[i][7] == "Y") {
                    existing_Customer_Flag_value = 0.2840;
                }

                if (records[i][15] == "" || !(int.TryParse(records[i][15], out number)))
                {
                    finalResult.Add(long.Parse(records[i][0]), "Invalid Number of Dependants!");
                    continue;
                }
                if (int.Parse(records[i][15]) < 3) {
                    number_of_Dependants_value = 0.2950;
                }
                else if(int.Parse(records[i][15]) >= 3) {
                    number_of_Dependants_value = 0.1422;
                }

                if (records[i][17] == "")
                {
                    finalResult.Add(long.Parse(records[i][0]), "Invalid Occupation Code!");
                    continue;
                }
                if (records[i][17] == "M" || records[i][17] == "B")
                {
                    occupation_Code_value = 0.1570;
                }
                else if (records[i][17] == "P" || records[i][17] == "O") 
                {
                    occupation_Code_value = 0.2802;
                }

                if (records[i][19] == "")
                {
                    finalResult.Add(long.Parse(records[i][0]), "Invalid Residential Status!");
                    continue;
                }
                if (records[i][19] == "H") {
                    residential_Status_value = 0.2305;
                }
                else if (records[i][19] == "L" || records[i][19] == "O" || records[i][19] == "T") {
                    residential_Status_value = 0.2067;
                }

                if (records[i][21] == "" || !(int.TryParse(records[i][21], out number)))
                {
                    finalResult.Add(long.Parse(records[i][0]), "Invalid Time in Employment!");
                    continue;
                }
                if (int.Parse(records[i][21]) < 500) {
                    time_in_Employment_value = 0.1369;
                }
                else if(int.Parse(records[i][21]) >= 500) {
                    time_in_Employment_value = 0.3003;
                }

                if (records[i][27] == "" || !(int.TryParse(records[i][27], out number)))
                {
                    finalResult.Add(long.Parse(records[i][0]), "Invalid Bureau Score!");
                    continue;
                }
                if (int.Parse(records[i][27]) < 746) {
                    bureau_Score_value = -1.5400;
                }
                else if(int.Parse(records[i][27]) < 803) {
                    bureau_Score_value = -1.1212;
                }
                else if (int.Parse(records[i][27]) < 844) {
                    bureau_Score_value = -0.7227;
                }
                else if (int.Parse(records[i][27]) < 859) {
                    bureau_Score_value = -0.6100;
                }
                else if (int.Parse(records[i][27]) < 875) {
                    bureau_Score_value = -0.3877;
                }
                else if (int.Parse(records[i][27]) < 902) {
                    bureau_Score_value = -0.2483;
                }
                else if (int.Parse(records[i][27]) < 922) {
                    bureau_Score_value = -0.2353;
                }
                else if (int.Parse(records[i][27]) < 950) {
                    bureau_Score_value = 0.2685;
                }
                else if (int.Parse(records[i][27]) < 972) {
                    bureau_Score_value = 0.4053;
                }
                else if (int.Parse(records[i][27]) < 990) {
                    bureau_Score_value = 0.9314;
                }
                else if (int.Parse(records[i][27]) < 1012) {
                    bureau_Score_value = 0.9770;
                }
                else if (int.Parse(records[i][27]) < 1025) {
                    bureau_Score_value = 1.0831;
                }
                else if (int.Parse(records[i][27]) >= 1025) {
                    bureau_Score_value = 1.6371;
                }

                if (records[i][28] == "" || !(int.TryParse(records[i][28], out number)))
                {
                    finalResult.Add(long.Parse(records[i][0]), "Invalid SP ER Reference!");
                    continue;
                }
                if (int.Parse(records[i][28]) <= 2) {
                    sp_ER_Reference_value = 0.1647;
                }
                else if(int.Parse(records[i][28]) >= 3) {
                    sp_ER_Reference_value = 0.2725;
                }

                if (records[i][29] == "" || !(int.TryParse(records[i][29], out number)))
                {
                    finalResult.Add(long.Parse(records[i][0]), "Invalid SP Number of Searches L6M!");
                    continue;
                }
                if (int.Parse(records[i][29]) < 3) {
                    sp_Number_Of_Searches_L6M_value = 0.3160;
                }
                else if(int.Parse(records[i][29]) >= 3) {
                    sp_Number_Of_Searches_L6M_value = 0.1212;
                }

                if (records[i][30] == "" || !(int.TryParse(records[i][30], out number)))
                {
                    finalResult.Add(long.Parse(records[i][0]), "Invalid SP Number of CCJs!");
                    continue;
                }
                if (int.Parse(records[i][30]) < 1)
                {
                    sp_Number_of_CCJs_value = 0.7142;
                }
                else if (int.Parse(records[i][30]) < 6)
                {
                    sp_Number_of_CCJs_value = 0.5015;
                }
                else if (int.Parse(records[i][30]) >= 6)
                {
                    sp_Number_of_CCJs_value = -0.7785;

                }

                value = existing_Customer_Flag_value + number_of_Dependants_value + occupation_Code_value
                        + residential_Status_value + time_in_Employment_value + bureau_Score_value + sp_ER_Reference_value + sp_Number_of_CCJs_value
                        + sp_Number_Of_Searches_L6M_value;
                score = (0.8275 + value) * 100;

                if (score > 300)
                {
                    result = "good";
                }
                else if (score < 250)
                {
                    result = "bad";
                }
                else if (score >= 250 && score <= 300) 
                {
                    result = "manually review";
                }
                finalResult.Add(long.Parse(records[i][0]), result);
            }
            Console.WriteLine();
            return finalResult;
        }
        private void addToFile(Dictionary<long, string> result, string filename) 
        {
            using (FileStream fileStream = System.IO.File.Create(filename))
            {

            }
            using (StreamWriter file = new StreamWriter(filename)) 
            {
                foreach (var entry in result)
                {
                    file.WriteLine("[{0} {1}]", entry.Key, entry.Value);
                }
            }
            
        }
    }
}
