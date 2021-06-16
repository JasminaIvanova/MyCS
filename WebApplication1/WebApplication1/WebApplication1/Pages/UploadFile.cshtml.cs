using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace WebApplication1.Pages
{
    public class UploadFileModel : PageModel
    {
        public void OnGet()
        {
        }

        private IWebHostEnvironment _environment;
        public UploadFileModel(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        [BindProperty]
        public IFormFile Upload { get; set; }
        public async Task OnPostAsync()
        {
            List<string> records = new List<string>();
            var file = Path.Combine(_environment.ContentRootPath, "Files", Upload.FileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
            }

            using (TextFieldParser csvParser = new TextFieldParser(file))
            {
                //csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                //csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    records.Add(fields[0]);
                }
            }
            Console.WriteLine();
        }
    }
}

