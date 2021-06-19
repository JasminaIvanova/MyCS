using CsvHelper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.FileIO;
using MyCS.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyCS.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index(List<List<string>> clientsData)
        {
           // clientsData = clientsData == null ? new List<List<string>>() : clientsData;
            return View(clientsData);
        }

        [HttpPost]

        public IActionResult Index(IFormFile file)
        {
            if (file == null)
                return View("UploadError");
            #region Upload CSV
            string fileName = $"{Directory.GetCurrentDirectory()}{@"\Files"}" + "\\" + file.FileName;
            
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
            var path = $"{Directory.GetCurrentDirectory()}{@"\Files"}" + "\\" + fileName;
            using (TextFieldParser csv = new TextFieldParser(path))
            {
                csv.SetDelimiters(new string[] { "," });
                csv.ReadLine();

                while (!csv.EndOfData)
                {
                    
                    string[] fields = csv.ReadFields();
                    List<string> data = fields[0].Split(";").ToList();
                    records.Add(data);
                }
                Console.WriteLine();
            }
            return records;
            #endregion


        }
    }
}
