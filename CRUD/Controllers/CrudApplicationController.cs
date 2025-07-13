using CRUD.CommonLayer.Models;
using CRUD.ServiceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PdfSharp.Pdf;
using PdfSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static CRUD.CommonLayer.Models.SalarySearchByDate;
using static CRUD.CommonLayer.Models.SearchInformationByDate;
using Azure.Core;
using Azure;
using static System.Collections.Specialized.BitVector32;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudApplicationController : ControllerBase
    {
        public readonly ICrudAppliactionSL _crudApplicationSL;
        

        public CrudApplicationController(ICrudAppliactionSL crudAppliactionSL )
        {
            _crudApplicationSL = crudAppliactionSL;
            
        }


        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            LoginResponse response = null;
            try
            {

                response = await _crudApplicationSL.Login(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            RegisterResponse response = null;
            try
            {

                response = await _crudApplicationSL.Register(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }


        [HttpPost]
        [Route("ECreateInformation")]
        public async Task<IActionResult> CreateInformation(ECreateInformationRequest request)
        {
            CreateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.CreateInformation(request);

            }catch(Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("WCreateInformation")]
        public async Task<IActionResult> CreateInformation(WCreateInformationRequest request)
        {
            CreateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.CreateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("JCreateInformation")]
        public async Task<IActionResult> CreateInformation(JCreateInformationRequest request)
        {
            CreateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.CreateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("JSCreateInformation")]
        public async Task<IActionResult> CreateInformation(JSCreateInformationRequest request)
        {
            CreateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.CreateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("LVTCreateInformation")]
        public async Task<IActionResult> CreateInformation(LVTCreateInformationRequest request)
        {
            CreateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.CreateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("EmpATTCreateInformation")]
        public async Task<IActionResult> CreateInformation(EmpATTCreateInformationRequest request)
        {
            CreateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.CreateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("WorkerATTCreateInformation")]
        public async Task<IActionResult> CreateInformation(WorkerATTCreateInformationRequest request)
        {
            CreateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.CreateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }






        [HttpGet]
        [Route("EReadInformation")]
        public async Task<IActionResult> EReadInformation()
        {
            EReadInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.EReadInformation();

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("WReadInformation")]
        public async Task<IActionResult> WReadInformation()
        {
            EReadInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.WReadInformation();

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("JReadInformation")]
        public async Task<IActionResult> JReadInformation()
        {
            EReadInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.JReadInformation();

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("ECReadInformation")]
        public async Task<IActionResult> ECReadInformation()
        {
            EReadInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.ECReadInformation();

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("WCReadInformation")]
        public async Task<IActionResult> WCReadInformation()
        {
            EReadInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.WCReadInformation();

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("JCReadInformation")]
        public async Task<IActionResult> JCReadInformation()
        {
            EReadInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.JCReadInformation();

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("SReadInformation")]
        public async Task<IActionResult> SReadInformation()
        {
            EReadInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.SReadInformation();

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }


        [HttpGet]
        [Route("JSReadInformation")]
        public async Task<IActionResult> JSReadInformation()
        {
            EReadInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.JSReadInformation();

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("JSCReadInformation")]
        public async Task<IActionResult> JSCReadInformation()
        {
            EReadInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.JSCReadInformation();

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("BReadInformation")]
        public async Task<IActionResult> BReadInformation()
        {
            EReadInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.BReadInformation();

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }


        [HttpGet]
        [Route("LVTReadInformation")]
        public async Task<IActionResult> LVTReadInformation()
        {
            EReadInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.LVTReadInformation();

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpGet]
        [Route("WagReadInformation")]
        public async Task<IActionResult> WagReadInformation()
        {
            EReadInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.WagReadInformation();

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }





        [HttpPost]
        [Route(("generatesalarypdf"))]
        public async Task<IActionResult> GenerateSalaryPDF(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = null;
            try
            {
                response = await _crudApplicationSL.WSearchInformationBySection(request);
                if (response == null || !response.IsSuccess)
                {
                    return BadRequest("Failed to fetch salary data: " + (response?.Message ?? "Unknown error"));
                }

                // Create a new PDF document using PDFsharp
                var document = new PdfSharp.Pdf.PdfDocument();
                document.Info.Title = "Salary Report";
                document.Info.Author = "CRUD Application";

                // Create a page for the document
                var page = document.AddPage();
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var font = new PdfSharp.Drawing.XFont("Arial", 12);
                var boldFont = new PdfSharp.Drawing.XFont("Arial", 12);
                var titleFont = new PdfSharp.Drawing.XFont("Arial", 18);
                var smallFont = new PdfSharp.Drawing.XFont("Arial", 10);

                // Set page margins and positions
                double margin = 50;
                double currentY = margin;
                double pageWidth = page.Width.Point;

                // Add title
                graphics.DrawString("Salary Report by Section", titleFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, pageWidth - 2 * margin, 30),
                    PdfSharp.Drawing.XStringFormats.TopCenter);
                currentY += 30;

                // Add subtitle
                string subtitle = $"Section ID: {request.Id} | Month: {request.Date}";
                graphics.DrawString(subtitle, boldFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, pageWidth - 2 * margin, 20),
                    PdfSharp.Drawing.XStringFormats.TopCenter);
                currentY += 30;

                // Define table layout
                double[] columnWidths = { 40, 100, 70, 100, 100, 60, 60, 60 };
                string[] headers = { "ID", "Name", "Card No", "Job Name", "Bank A/C", "Salary", "Work Days", "Net" };
                double cellHeight = 20;
                double tableWidth = 0;
                foreach (var width in columnWidths)
                    tableWidth += width;

                double tableStartX = (pageWidth - tableWidth) / 2;
                double tableX = tableStartX;

                // Draw table headers
                for (int i = 0; i < headers.Length; i++)
                {
                    // Draw cell background and border
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        PdfSharp.Drawing.XBrushes.LightGray,
                        tableX, currentY, columnWidths[i], cellHeight);

                    // Draw header text
                    graphics.DrawString(headers[i], boldFont,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX, currentY, columnWidths[i], cellHeight),
                        PdfSharp.Drawing.XStringFormats.Center);

                    tableX += columnWidths[i];
                }
                currentY += cellHeight;

                // Draw table data
                if (response.wsearchInformationBySection != null && response.wsearchInformationBySection.Count > 0)
                {
                    foreach (var worker in response.wsearchInformationBySection)
                    {
                        // Check if we need a new page
                        if (currentY + cellHeight > page.Height.Point - margin)
                        {
                            page = document.AddPage();
                            graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                            currentY = margin;
                        }

                        tableX = tableStartX;
                        string[] rowData = {
                    worker.Id.ToString(),
                    worker.Name ?? "",
                    worker.CardNo ?? "",
                    worker.JobName ?? "",
                    worker.BankAC ?? "",
                    worker.Salary.ToString(),
                    worker.Work_Day.ToString(),
                    worker.Net.ToString()
                };

                        for (int i = 0; i < rowData.Length; i++)
                        {
                            // Draw cell border
                            graphics.DrawRectangle(
                                PdfSharp.Drawing.XPens.Black,
                                tableX, currentY, columnWidths[i], cellHeight);

                            // Draw cell text
                            graphics.DrawString(rowData[i], font,
                                PdfSharp.Drawing.XBrushes.Black,
                                new PdfSharp.Drawing.XRect(tableX + 2, currentY, columnWidths[i] - 4, cellHeight),
                                PdfSharp.Drawing.XStringFormats.CenterLeft);

                            tableX += columnWidths[i];
                        }
                        currentY += cellHeight;
                    }
                }
                else
                {
                    tableX = tableStartX;
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        tableX, currentY, tableWidth, cellHeight);

                    graphics.DrawString("No data available", font,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX, currentY, tableWidth, cellHeight),
                        PdfSharp.Drawing.XStringFormats.Center);

                    currentY += cellHeight;
                }

                // Add summary section (on a new page if needed)
                currentY += 30;
                if (currentY + 120 > page.Height.Point - margin) // Increased space requirement for net pay in words
                {
                    page = document.AddPage();
                    graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                    currentY = margin;
                }

                // Calculate totals
                int totalWorkers = response.wsearchInformationBySection?.Count ?? 0;
                int totalSalary = 0;
                int totalNetPayment = 0;

                if (response.wsearchInformationBySection != null)
                {
                    foreach (var worker in response.wsearchInformationBySection)
                    {
                        totalSalary += worker.Salary;
                        totalNetPayment += worker.Net;
                    }
                }

                // Draw summary title
                graphics.DrawString("Summary Information", boldFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, pageWidth - 2 * margin, 20),
                    PdfSharp.Drawing.XStringFormats.TopCenter);
                currentY += 25;

                // Define summary table
                double[] summaryWidths = { 100, 100, 100 };
                string[] summaryHeaders = { "Total Workers", "Total Salary", "Total Net Payment" };
                double summaryTableWidth = 300;
                double summaryStartX = (pageWidth - summaryTableWidth) / 2;

                // Draw summary headers
                tableX = summaryStartX;
                for (int i = 0; i < summaryHeaders.Length; i++)
                {
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        PdfSharp.Drawing.XBrushes.LightGray,
                        tableX, currentY, summaryWidths[i], cellHeight);

                    graphics.DrawString(summaryHeaders[i], boldFont,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX, currentY, summaryWidths[i], cellHeight),
                        PdfSharp.Drawing.XStringFormats.Center);

                    tableX += summaryWidths[i];
                }
                currentY += cellHeight;

                // Draw summary data
                tableX = summaryStartX;
                string[] summaryData = {
            totalWorkers.ToString(),
            totalSalary.ToString(),
            totalNetPayment.ToString()
        };

                for (int i = 0; i < summaryData.Length; i++)
                {
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        tableX, currentY, summaryWidths[i], cellHeight);

                    graphics.DrawString(summaryData[i], font,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX, currentY, summaryWidths[i], cellHeight),
                        PdfSharp.Drawing.XStringFormats.Center);

                    tableX += summaryWidths[i];
                }
                currentY += cellHeight;

                // Add Net Payment in Words section
                currentY += 15;
                string netPaymentInWords = ConvertNumberToWords(totalNetPayment);

                graphics.DrawString("Net Payment in Words:", boldFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, 150, 20),
                    PdfSharp.Drawing.XStringFormats.CenterLeft);

                currentY += 20;

                // Draw a box around the amount in words
                double wordsBoxWidth = pageWidth - 2 * margin;
                double wordsBoxHeight = 25;

                graphics.DrawRectangle(
                    PdfSharp.Drawing.XPens.Black,
                    PdfSharp.Drawing.XBrushes.White,
                    margin, currentY, wordsBoxWidth, wordsBoxHeight);

                graphics.DrawString(netPaymentInWords, font,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin + 5, currentY, wordsBoxWidth - 10, wordsBoxHeight),
                    PdfSharp.Drawing.XStringFormats.CenterLeft);

                // Convert PDF to byte array
                byte[] pdfBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    document.Save(ms);
                    pdfBytes = ms.ToArray();
                }

                // Return PDF file
                string filename = "SalaryReport_Section" + request.Id + "_" + request.Date + ".pdf";
                return File(pdfBytes, "application/pdf", filename);
            }
            catch (Exception ex)
            {
                // Log the error
                return BadRequest("Error generating PDF: " + ex.Message);
            }
        }

        // Helper method to convert numbers to words
        private string ConvertNumberToWords(int number)
        {
            if (number == 0)
                return "Zero Taka Only";

            if (number < 0)
                return "Minus " + ConvertNumberToWords(Math.Abs(number));

            return ConvertToWordsHelper(number).Trim() + " Taka Only";
        }

        private string ConvertToWordsHelper(int number)
        {
            var unitsMap = new[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            var tensMap = new[] { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (number == 0)
                return "";

            string words = "";

            // Handle crores (10,000,000)
            if (number >= 10000000)
            {
                words += ConvertToWordsHelper(number / 10000000) + " Crore ";
                number %= 10000000;
            }

            // Handle lakhs (100,000)
            if (number >= 100000)
            {
                words += ConvertToWordsHelper(number / 100000) + " Lakh ";
                number %= 100000;
            }

            // Handle thousands (1,000)
            if (number >= 1000)
            {
                words += ConvertToWordsHelper(number / 1000) + " Thousand ";
                number %= 1000;
            }

            // Handle hundreds (100)
            if (number >= 100)
            {
                words += unitsMap[number / 100] + " Hundred ";
                number %= 100;
            }

            // Handle remaining numbers (1-99)
            if (number > 0)
            {
                if (words.Length > 0)
                    words += "and ";

                if (number < 20)
                {
                    words += unitsMap[number];
                }
                else
                {
                    words += tensMap[number / 10];
                    if (number % 10 > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
        [HttpPost]
        [Route(("generatebonuspdf"))]
        public async Task<IActionResult> GenerateBonusPDF(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = null;
            try
            {
                response = await _crudApplicationSL.BSalSearchInformationBySection(request);
                if (response == null || !response.IsSuccess)
                {
                    return BadRequest("Failed to fetch bonus data: " + (response?.Message ?? "Unknown error"));
                }

                // Create a new PDF document using PDFsharp
                var document = new PdfSharp.Pdf.PdfDocument();
                document.Info.Title = "Bonus Report";
                document.Info.Author = "CRUD Application";

                // Create a page for the document
                var page = document.AddPage();
                page.Orientation = PdfSharp.PageOrientation.Landscape;
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var font = new PdfSharp.Drawing.XFont("Arial", 12);
                var boldFont = new PdfSharp.Drawing.XFont("Arial", 12);
                var titleFont = new PdfSharp.Drawing.XFont("Arial", 18);
                var smallFont = new PdfSharp.Drawing.XFont("Arial", 10);

                // Set page margins and positions
                double margin = 50;
                double currentY = margin;
                double pageWidth = page.Width.Point;

                // Add title
                graphics.DrawString("Bonus Report by Section", titleFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, pageWidth - 2 * margin, 30),
                    PdfSharp.Drawing.XStringFormats.TopCenter);
                currentY += 40;

                // Add subtitle
                string subtitle = $"Section ID: {request.Id} | Month: {request.Date}";
                graphics.DrawString(subtitle, boldFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, pageWidth - 2 * margin, 20),
                    PdfSharp.Drawing.XStringFormats.TopCenter);
                currentY += 40;

                // Define table layout - Fixed to match 9 columns
                double[] columnWidths = { 50, 100, 80, 55, 50, 50, 40, 40, 150 };
                string[] headers = { "Card No", "Name", "Job Name", "Bank A/C", "Bonus", "Gross", "Deduct", "Net", "Bonus Type" };
                double cellHeight = 25;
                double tableWidth = 0;
                foreach (var width in columnWidths)
                    tableWidth += width;

                double tableStartX = (pageWidth - tableWidth) / 2;
                double tableX = tableStartX;

                // Draw table headers
                for (int i = 0; i < headers.Length; i++)
                {
                    // Draw cell background and border
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        PdfSharp.Drawing.XBrushes.LightGray,
                        tableX, currentY, columnWidths[i], cellHeight);

                    // Draw header text
                    graphics.DrawString(headers[i], boldFont,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, columnWidths[i] - 4, cellHeight - 4),
                        PdfSharp.Drawing.XStringFormats.Center);

                    tableX += columnWidths[i];
                }
                currentY += cellHeight;

                // Draw table data
                if (response.bsalsearchInformationBySection != null && response.bsalsearchInformationBySection.Count > 0)
                {
                    foreach (var worker in response.bsalsearchInformationBySection)
                    {
                        // Check if we need a new page
                        if (currentY + cellHeight > page.Height.Point - margin - 100)
                        {
                            // Dispose current graphics before creating new page
                            graphics.Dispose();
                            page = document.AddPage();
                            page.Orientation = PdfSharp.PageOrientation.Landscape;
                            graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                            currentY = margin;

                            // Redraw headers on new page
                            tableX = tableStartX;
                            for (int i = 0; i < headers.Length; i++)
                            {
                                graphics.DrawRectangle(
                                    PdfSharp.Drawing.XPens.Black,
                                    PdfSharp.Drawing.XBrushes.LightGray,
                                    tableX, currentY, columnWidths[i], cellHeight);

                                graphics.DrawString(headers[i], boldFont,
                                    PdfSharp.Drawing.XBrushes.Black,
                                    new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, columnWidths[i] - 4, cellHeight - 4),
                                    PdfSharp.Drawing.XStringFormats.Center);

                                tableX += columnWidths[i];
                            }
                            currentY += cellHeight;
                        }

                        tableX = tableStartX;
                        string[] rowData = {
                    worker.CardNo ?? "",
                    worker.Name ?? "",
                    worker.JobName ?? "",
                    worker.BankAC ?? "",
                    worker.Bonus.ToString() ?? "0",
                    worker.Gross.ToString() ?? "0",
                    worker.Deduct.ToString() ?? "0",
                    worker.Net.ToString() ?? "0",
                    worker.BType ?? ""
                };

                        for (int i = 0; i < rowData.Length && i < columnWidths.Length; i++)
                        {
                            // Draw cell border
                            graphics.DrawRectangle(
                                PdfSharp.Drawing.XPens.Black,
                                tableX, currentY, columnWidths[i], cellHeight);

                            // Draw cell text with proper alignment
                            var textAlignment = (i >= 4 && i <= 7) ?
                                PdfSharp.Drawing.XStringFormats.CenterRight :
                                PdfSharp.Drawing.XStringFormats.CenterLeft;

                            graphics.DrawString(rowData[i], font,
                                PdfSharp.Drawing.XBrushes.Black,
                                new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, columnWidths[i] - 4, cellHeight - 4),
                                textAlignment);

                            tableX += columnWidths[i];
                        }
                        currentY += cellHeight;
                    }
                }
                else
                {
                    tableX = tableStartX;
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        tableX, currentY, tableWidth, cellHeight);

                    graphics.DrawString("No data available", font,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX, currentY, tableWidth, cellHeight),
                        PdfSharp.Drawing.XStringFormats.Center);

                    currentY += cellHeight;
                }

                // Add summary section (on a new page if needed)
                currentY += 40;
                if (currentY + 150 > page.Height.Point - margin) // Increased space requirement for net pay in words
                {
                    graphics.Dispose();
                    page = document.AddPage();
                    page.Orientation = PdfSharp.PageOrientation.Landscape;
                    graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                    currentY = margin;
                }

                // Calculate totals
                int totalWorkers = response.bsalsearchInformationBySection?.Count ?? 0;
                decimal totalBonus = 0;
                decimal totalGross = 0;
                decimal totalDeduct = 0;
                decimal totalNet = 0;

                if (response.bsalsearchInformationBySection != null)
                {
                    foreach (var worker in response.bsalsearchInformationBySection)
                    {
                        totalBonus += worker.Bonus;
                        totalGross += worker.Gross;
                        totalDeduct += worker.Deduct;
                        totalNet += worker.Net;
                    }
                }

                // Draw summary title
                graphics.DrawString("Summary Information", boldFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, pageWidth - 2 * margin, 25),
                    PdfSharp.Drawing.XStringFormats.TopCenter);
                currentY += 35;

                // Define summary table
                double[] summaryWidths = { 80, 80, 80, 80, 80 };
                string[] summaryHeaders = { "Total Workers", "Total Bonus", "Total Gross", "Total Deduct", "Total Net" };
                double summaryTableWidth = summaryWidths.Sum();
                double summaryStartX = (pageWidth - summaryTableWidth) / 2;

                // Draw summary headers
                tableX = summaryStartX;
                for (int i = 0; i < summaryHeaders.Length; i++)
                {
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        PdfSharp.Drawing.XBrushes.LightGray,
                        tableX, currentY, summaryWidths[i], cellHeight);

                    graphics.DrawString(summaryHeaders[i], boldFont,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, summaryWidths[i] - 4, cellHeight - 4),
                        PdfSharp.Drawing.XStringFormats.Center);

                    tableX += summaryWidths[i];
                }
                currentY += cellHeight;

                // Draw summary data
                tableX = summaryStartX;
                string[] summaryData = {
            totalWorkers.ToString(),
            totalBonus.ToString("N0"),
            totalGross.ToString("N0"),
            totalDeduct.ToString("N0"),
            totalNet.ToString("N0")
        };

                for (int i = 0; i < summaryData.Length; i++)
                {
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        tableX, currentY, summaryWidths[i], cellHeight);

                    graphics.DrawString(summaryData[i], font,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, summaryWidths[i] - 4, cellHeight - 4),
                        PdfSharp.Drawing.XStringFormats.Center);

                    tableX += summaryWidths[i];
                }
                currentY += cellHeight;

                // Add Net Payment in Words section
                currentY += 20;
                string netPaymentInWords = ConvertNumberToWords((int)totalNet);

                graphics.DrawString("Total Net Payment in Words:", boldFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, 200, 20),
                    PdfSharp.Drawing.XStringFormats.CenterLeft);

                currentY += 25;

                // Draw a box around the amount in words
                double wordsBoxWidth = pageWidth - 2 * margin;
                double wordsBoxHeight = 30;

                graphics.DrawRectangle(
                    PdfSharp.Drawing.XPens.Black,
                    PdfSharp.Drawing.XBrushes.White,
                    margin, currentY, wordsBoxWidth, wordsBoxHeight);

                graphics.DrawString(netPaymentInWords, font,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin + 5, currentY, wordsBoxWidth - 10, wordsBoxHeight),
                    PdfSharp.Drawing.XStringFormats.CenterLeft);

                // Dispose graphics before saving
                graphics.Dispose();

                // Convert PDF to byte array
                byte[] pdfBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    document.Save(ms);
                    pdfBytes = ms.ToArray();
                }

                // Dispose document
                document.Dispose();

                // Return PDF file
                string filename = $"BonusReport_Section{request.Id}_{request.Date:yyyyMM}.pdf";
                return File(pdfBytes, "application/pdf", filename);
            }
            catch (Exception ex)
            {
                // Log the error (consider using a proper logging framework)
                return BadRequest("Error generating PDF: " + ex.Message);
            }
        }
        [HttpPost]
        [Route(("generateotpdf"))]
        public async Task<IActionResult> GenerateOTPDF(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = null;
            try
            {
                response = await _crudApplicationSL.OTSearchInformationBySection(request);
                if (response == null || !response.IsSuccess)
                {
                    return BadRequest("Failed to fetch OT data: " + (response?.Message ?? "Unknown error"));
                }

                // Create a new PDF document using PDFsharp
                var document = new PdfSharp.Pdf.PdfDocument();
                document.Info.Title = "OT Report";
                document.Info.Author = "CRUD Application";

                // Create a page for the document
                var page = document.AddPage();
                page.Orientation = PdfSharp.PageOrientation.Landscape;
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var font = new PdfSharp.Drawing.XFont("Arial", 12);
                var boldFont = new PdfSharp.Drawing.XFont("Arial", 12);
                var titleFont = new PdfSharp.Drawing.XFont("Arial", 18);
                var smallFont = new PdfSharp.Drawing.XFont("Arial", 10);

                // Set page margins and positions
                double margin = 50;
                double currentY = margin;
                double pageWidth = page.Width.Point;

                // Add title
                graphics.DrawString("OT Report by Section", titleFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, pageWidth - 2 * margin, 30),
                    PdfSharp.Drawing.XStringFormats.TopCenter);
                currentY += 40;

                // Add subtitle
                string subtitle = $"Section ID: {request.Id} | Month: {request.Date}";
                graphics.DrawString(subtitle, boldFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, pageWidth - 2 * margin, 20),
                    PdfSharp.Drawing.XStringFormats.TopCenter);
                currentY += 40;

                // Define table layout - Fixed to match 9 columns
                double[] columnWidths = { 50, 100, 80, 55, 50, 50, 40, 40, 150 };
                string[] headers = { "Card No", "Name", "Job Name", "Bank A/C", "Hours", "Gross", "Deduct", "Net", "Month" };
                double cellHeight = 25;
                double tableWidth = 0;
                foreach (var width in columnWidths)
                    tableWidth += width;

                double tableStartX = (pageWidth - tableWidth) / 2;
                double tableX = tableStartX;

                // Draw table headers
                for (int i = 0; i < headers.Length; i++)
                {
                    // Draw cell background and border
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        PdfSharp.Drawing.XBrushes.LightGray,
                        tableX, currentY, columnWidths[i], cellHeight);

                    // Draw header text
                    graphics.DrawString(headers[i], boldFont,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, columnWidths[i] - 4, cellHeight - 4),
                        PdfSharp.Drawing.XStringFormats.Center);

                    tableX += columnWidths[i];
                }
                currentY += cellHeight;

                // Draw table data
                if (response.otsearchInformationBySection != null && response.otsearchInformationBySection.Count > 0)
                {
                    foreach (var worker in response.otsearchInformationBySection)
                    {
                        // Check if we need a new page
                        if (currentY + cellHeight > page.Height.Point - margin - 100)
                        {
                            // Dispose current graphics before creating new page
                            graphics.Dispose();
                            page = document.AddPage();
                            page.Orientation = PdfSharp.PageOrientation.Landscape;
                            graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                            currentY = margin;

                            // Redraw headers on new page
                            tableX = tableStartX;
                            for (int i = 0; i < headers.Length; i++)
                            {
                                graphics.DrawRectangle(
                                    PdfSharp.Drawing.XPens.Black,
                                    PdfSharp.Drawing.XBrushes.LightGray,
                                    tableX, currentY, columnWidths[i], cellHeight);

                                graphics.DrawString(headers[i], boldFont,
                                    PdfSharp.Drawing.XBrushes.Black,
                                    new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, columnWidths[i] - 4, cellHeight - 4),
                                    PdfSharp.Drawing.XStringFormats.Center);

                                tableX += columnWidths[i];
                            }
                            currentY += cellHeight;
                        }

                        tableX = tableStartX;
                        string[] rowData = {
                    worker.CardNo ?? "",
                    worker.Name ?? "",
                    worker.JobName ?? "",
                    worker.BankAC ?? "",
                    worker.Hour.ToString() ?? "0",
                    worker.Gross.ToString() ?? "0",
                    worker.Deduct.ToString() ?? "0",
                    worker.Net_OT.ToString() ?? "0",
                    worker.Month ?? ""
                };

                        for (int i = 0; i < rowData.Length && i < columnWidths.Length; i++)
                        {
                            // Draw cell border
                            graphics.DrawRectangle(
                                PdfSharp.Drawing.XPens.Black,
                                tableX, currentY, columnWidths[i], cellHeight);

                            // Draw cell text with proper alignment
                            var textAlignment = (i >= 4 && i <= 7) ?
                                PdfSharp.Drawing.XStringFormats.CenterRight :
                                PdfSharp.Drawing.XStringFormats.CenterLeft;

                            graphics.DrawString(rowData[i], font,
                                PdfSharp.Drawing.XBrushes.Black,
                                new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, columnWidths[i] - 4, cellHeight - 4),
                                textAlignment);

                            tableX += columnWidths[i];
                        }
                        currentY += cellHeight;
                    }
                }
                else
                {
                    tableX = tableStartX;
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        tableX, currentY, tableWidth, cellHeight);

                    graphics.DrawString("No data available", font,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX, currentY, tableWidth, cellHeight),
                        PdfSharp.Drawing.XStringFormats.Center);

                    currentY += cellHeight;
                }

                // Add summary section (on a new page if needed)
                currentY += 40;
                if (currentY + 150 > page.Height.Point - margin) // Increased space requirement for net pay in words
                {
                    graphics.Dispose();
                    page = document.AddPage();
                    page.Orientation = PdfSharp.PageOrientation.Landscape;
                    graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                    currentY = margin;
                }

                // Calculate totals
                int totalWorkers = response.otsearchInformationBySection?.Count ?? 0;
                decimal totalHour = 0;
                decimal totalGross = 0;
                decimal totalDeduct = 0;
                decimal totalNet = 0;

                if (response.otsearchInformationBySection != null)
                {
                    foreach (var worker in response.otsearchInformationBySection)
                    {
                        totalHour += worker.Hour;
                        totalGross += worker.Gross;
                        totalDeduct += worker.Deduct;
                        totalNet += worker.Net_OT;
                    }
                }

                // Draw summary title
                graphics.DrawString("Summary Information", boldFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, pageWidth - 2 * margin, 25),
                    PdfSharp.Drawing.XStringFormats.TopCenter);
                currentY += 35;

                // Define summary table
                double[] summaryWidths = { 80, 80, 80, 80, 80 };
                string[] summaryHeaders = { "Total Workers", "Total Hours", "Total Gross", "Total Deduct", "Total Net" };
                double summaryTableWidth = summaryWidths.Sum();
                double summaryStartX = (pageWidth - summaryTableWidth) / 2;

                // Draw summary headers
                tableX = summaryStartX;
                for (int i = 0; i < summaryHeaders.Length; i++)
                {
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        PdfSharp.Drawing.XBrushes.LightGray,
                        tableX, currentY, summaryWidths[i], cellHeight);

                    graphics.DrawString(summaryHeaders[i], boldFont,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, summaryWidths[i] - 4, cellHeight - 4),
                        PdfSharp.Drawing.XStringFormats.Center);

                    tableX += summaryWidths[i];
                }
                currentY += cellHeight;

                // Draw summary data
                tableX = summaryStartX;
                string[] summaryData = {
            totalWorkers.ToString(),
            totalHour.ToString("N0"),
            totalGross.ToString("N0"),
            totalDeduct.ToString("N0"),
            totalNet.ToString("N0")
        };

                for (int i = 0; i < summaryData.Length; i++)
                {
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        tableX, currentY, summaryWidths[i], cellHeight);

                    graphics.DrawString(summaryData[i], font,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, summaryWidths[i] - 4, cellHeight - 4),
                        PdfSharp.Drawing.XStringFormats.Center);

                    tableX += summaryWidths[i];
                }
                currentY += cellHeight;

                // Add Net Payment in Words section
                currentY += 20;
                string netPaymentInWords = ConvertNumberToWords((int)totalNet);

                graphics.DrawString("Total Net Payment in Words:", boldFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, 200, 20),
                    PdfSharp.Drawing.XStringFormats.CenterLeft);

                currentY += 25;

                // Draw a box around the amount in words
                double wordsBoxWidth = pageWidth - 2 * margin;
                double wordsBoxHeight = 30;

                graphics.DrawRectangle(
                    PdfSharp.Drawing.XPens.Black,
                    PdfSharp.Drawing.XBrushes.White,
                    margin, currentY, wordsBoxWidth, wordsBoxHeight);

                graphics.DrawString(netPaymentInWords, font,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin + 5, currentY, wordsBoxWidth - 10, wordsBoxHeight),
                    PdfSharp.Drawing.XStringFormats.CenterLeft);

                // Dispose graphics before saving
                graphics.Dispose();

                // Convert PDF to byte array
                byte[] pdfBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    document.Save(ms);
                    pdfBytes = ms.ToArray();
                }

                // Dispose document
                document.Dispose();

                // Return PDF file
                string filename = $"OTReport_Section{request.Id}_{request.Date:yyyyMM}.pdf";
                return File(pdfBytes, "application/pdf", filename);
            }
            catch (Exception ex)
            {
                // Log the error (consider using a proper logging framework)
                return BadRequest("Error generating PDF: " + ex.Message);
            }
        }
        [HttpPost]
        [Route(("generatewslippdf"))]
        public async Task<IActionResult> GenerateWSlipPDF(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = null;
            try
            {
                response = await _crudApplicationSL.WSlipSearchInformationBySection(request);
                if (response == null || !response.IsSuccess)
                {
                    return BadRequest("Failed to fetch Wages Slip data: " + (response?.Message ?? "Unknown error"));
                }

                // Create a new PDF document using PDFsharp
                var document = new PdfSharp.Pdf.PdfDocument();
                document.Info.Title = "Wages Slip Report";
                document.Info.Author = "CRUD Application";

                // Create a page for the document
                var page = document.AddPage();
                page.Orientation = PdfSharp.PageOrientation.Landscape;
                page.Size = PdfSharp.PageSize.A4; // Ensure A4 landscape

                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);

                // Define fonts with proper styling
                var font = new PdfSharp.Drawing.XFont("Arial", 9);
                var boldFont = new PdfSharp.Drawing.XFont("Arial", 9);
                var titleFont = new PdfSharp.Drawing.XFont("Arial", 16);
                var headerFont = new PdfSharp.Drawing.XFont("Arial", 8);

                // Set page margins and positions
                double margin = 30; // Reduced margin for more space
                double currentY = margin;
                double pageWidth = page.Width.Point;
                double usableWidth = pageWidth - (2 * margin);

                // Add title
                graphics.DrawString("Wages Slip Report by Section", titleFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, usableWidth, 25),
                    PdfSharp.Drawing.XStringFormats.TopCenter);
                currentY += 35;

                // Add subtitle
                
                string subtitle = $"Section ID: {request.Id} | Month: {request.Date:MMM yyyy}";
                graphics.DrawString(subtitle, boldFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, usableWidth, 20),
                    PdfSharp.Drawing.XStringFormats.TopCenter);
                currentY += 30;

                // Define table layout - 18 columns with proper proportions
                double[] columnWidths = {
            40,  // Card No
            80,  // Name
            60,  // Job Name
            50,  // Bank A/C
            35,  // Grade
            40,  // Basic
            35,  // HR
            40,  // Medical
            35,  // Conv
            35,  // Food
            45,  // Wages
            30,  // Days
            45,  // Att_Bonus
            40,  // Deduct
            50,  // Net_Wages
            50,  // OT_Amount
            45,  // OT_Hours
            30,  // Rate
            45  // Net_Pay
            
        };

                string[] headers = {
            "Card No", "Name", "Job Name", "Bank A/C", "Grade", "Basic", "HR",
            "Medical", "Conv", "Food", "Wages", "Days", "Att_Bonus", "Deduct",
            "Net_Wages", "OT_Amount", "OT_Hours","Rate", "Net_Pay"
        };

                double cellHeight = 22;
                double tableWidth = columnWidths.Sum();

                // Scale columns to fit page width if necessary
                if (tableWidth > usableWidth)
                {
                    double scaleFactor = usableWidth / tableWidth;
                    for (int i = 0; i < columnWidths.Length; i++)
                    {
                        columnWidths[i] *= scaleFactor;
                    }
                    tableWidth = usableWidth;
                }

                double tableStartX = margin;
                double tableX = tableStartX;

                // Draw table headers
                for (int i = 0; i < headers.Length; i++)
                {
                    // Draw cell background and border
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        PdfSharp.Drawing.XBrushes.LightGray,
                        tableX, currentY, columnWidths[i], cellHeight);

                    // Draw header text
                    graphics.DrawString(headers[i], headerFont,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, columnWidths[i] - 4, cellHeight - 4),
                        PdfSharp.Drawing.XStringFormats.Center);

                    tableX += columnWidths[i];
                }
                currentY += cellHeight;

                // Draw table data
                if (response.wslipsearchInformationBySection != null && response.wslipsearchInformationBySection.Count > 0)
                {
                    foreach (var worker in response.wslipsearchInformationBySection)
                    {
                        // Check if we need a new page
                        if (currentY + cellHeight > page.Height.Point - margin - 80)
                        {
                            // Dispose current graphics before creating new page
                            graphics.Dispose();
                            page = document.AddPage();
                            page.Orientation = PdfSharp.PageOrientation.Landscape;
                            page.Size = PdfSharp.PageSize.A4;
                            graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                            currentY = margin;

                            // Redraw headers on new page
                            tableX = tableStartX;
                            for (int i = 0; i < headers.Length; i++)
                            {
                                graphics.DrawRectangle(
                                    PdfSharp.Drawing.XPens.Black,
                                    PdfSharp.Drawing.XBrushes.LightGray,
                                    tableX, currentY, columnWidths[i], cellHeight);

                                graphics.DrawString(headers[i], headerFont,
                                    PdfSharp.Drawing.XBrushes.Black,
                                    new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, columnWidths[i] - 4, cellHeight - 4),
                                    PdfSharp.Drawing.XStringFormats.Center);

                                tableX += columnWidths[i];
                            }
                            currentY += cellHeight;
                        }

                        tableX = tableStartX;

                        // Fixed row data mapping - corrected order and removed duplicates
                        string[] rowData = {
                    worker.CardNo ?? "",                           // Card No
                    worker.Name ?? "",                             // Name
                    worker.JobName ?? "",                          // Job Name
                    worker.BankAcc ?? "",                          // Bank A/C
                    worker.Grade.ToString() ?? "0",                            // Grade
                    worker.Basic.ToString() ?? "0",                   // Basic
                    worker.HR.ToString() ?? "0",                      // HR
                    worker.Medical.ToString() ?? "0",                 // Medical
                    worker.Conv.ToString() ?? "0",                    // Conv
                    worker.Food.ToString() ?? "0",                    // Food
                    worker.Wages.ToString() ?? "0",                   // Wages
                    worker.Days.ToString() ?? "0" ,                        // Days
                    worker.Att_Bonus.ToString() ?? "0",              // Att_Bonus
                    worker.Deduct.ToString() ?? "0",                 // Deduct
                    worker.Net_Wages.ToString() ?? "0",              // Net_Wages
                    worker.OT_Amount.ToString() ?? "0",              // OT_Amount
                    worker.OT_Hours.ToString() ?? "0",               // OT_Hours
                    worker.Rate.ToString() ?? "0",                // Net_Pay
                    worker.Net_Pay.ToString() ?? "0"                            // Month
                };

                        for (int i = 0; i < rowData.Length && i < columnWidths.Length; i++)
                        {
                            // Draw cell border
                            graphics.DrawRectangle(
                                PdfSharp.Drawing.XPens.Black,
                                tableX, currentY, columnWidths[i], cellHeight);

                            // Determine text alignment based on column type
                            var textAlignment = PdfSharp.Drawing.XStringFormats.CenterLeft;

                            // Right align numeric columns
                            if (i >= 5 && i <= 17 && i != 11) // All numeric columns except Days
                            {
                                textAlignment = PdfSharp.Drawing.XStringFormats.CenterRight;
                            }
                            else if (i == 0 || i == 3 || i == 11 || i == 18) // Card No, Bank A/C, Days, Month
                            {
                                textAlignment = PdfSharp.Drawing.XStringFormats.Center;
                            }

                            graphics.DrawString(rowData[i], font,
                                PdfSharp.Drawing.XBrushes.Black,
                                new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, columnWidths[i] - 4, cellHeight - 4),
                                textAlignment);

                            tableX += columnWidths[i];
                        }
                        currentY += cellHeight;
                    }
                }
                else
                {
                    tableX = tableStartX;
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        tableX, currentY, tableWidth, cellHeight);

                    graphics.DrawString("No data available", font,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX, currentY, tableWidth, cellHeight),
                        PdfSharp.Drawing.XStringFormats.Center);

                    currentY += cellHeight;
                }

                // Add summary section (on a new page if needed)
                currentY += 30;
                if (currentY + 120 > page.Height.Point - margin)
                {
                    graphics.Dispose();
                    page = document.AddPage();
                    page.Orientation = PdfSharp.PageOrientation.Landscape;
                    page.Size = PdfSharp.PageSize.A4;
                    graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                    currentY = margin;
                }

                // Calculate totals
                int totalWorkers = response.wslipsearchInformationBySection?.Count ?? 0;
                decimal totalOTAmount = 0;
                decimal totalGross = 0;
                decimal totalDeduct = 0;
                decimal totalNet = 0;

                if (response.wslipsearchInformationBySection != null)
                {
                    foreach (var worker in response.wslipsearchInformationBySection)
                    {
                        totalOTAmount += worker.OT_Amount;
                        totalGross += worker.Gross_Wages;
                        totalDeduct += worker.Deduct;
                        totalNet += worker.Net_Pay;
                    }
                }

                // Draw summary title
                graphics.DrawString("Summary Information", boldFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, usableWidth, 20),
                    PdfSharp.Drawing.XStringFormats.TopCenter);
                currentY += 30;

                // Define summary table with proper widths
                double[] summaryWidths = { 100, 120, 100, 100, 100 };
                string[] summaryHeaders = { "Total Workers", "Total OT Amount", "Total Gross", "Total Deduct", "Total Net" };
                double summaryTableWidth = summaryWidths.Sum();
                double summaryStartX = margin + (usableWidth - summaryTableWidth) / 2;

                // Draw summary headers
                tableX = summaryStartX;
                for (int i = 0; i < summaryHeaders.Length; i++)
                {
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        PdfSharp.Drawing.XBrushes.LightGray,
                        tableX, currentY, summaryWidths[i], cellHeight);

                    graphics.DrawString(summaryHeaders[i], boldFont,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, summaryWidths[i] - 4, cellHeight - 4),
                        PdfSharp.Drawing.XStringFormats.Center);

                    tableX += summaryWidths[i];
                }
                currentY += cellHeight;

                // Draw summary data
                tableX = summaryStartX;
                string[] summaryData = {
            totalWorkers.ToString(),
            totalOTAmount.ToString("N0"),
            totalGross.ToString("N0"),
            totalDeduct.ToString("N0"),
            totalNet.ToString("N0")
        };

                for (int i = 0; i < summaryData.Length; i++)
                {
                    graphics.DrawRectangle(
                        PdfSharp.Drawing.XPens.Black,
                        tableX, currentY, summaryWidths[i], cellHeight);

                    graphics.DrawString(summaryData[i], font,
                        PdfSharp.Drawing.XBrushes.Black,
                        new PdfSharp.Drawing.XRect(tableX + 2, currentY + 2, summaryWidths[i] - 4, cellHeight - 4),
                        PdfSharp.Drawing.XStringFormats.Center);

                    tableX += summaryWidths[i];
                }
                currentY += cellHeight;

                // Add Net Payment in Words section
                currentY += 20;
                string netPaymentInWords = ConvertNumberToWords((int)totalNet);

                graphics.DrawString("Total Net Payment in Words:", boldFont,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin, currentY, 200, 20),
                    PdfSharp.Drawing.XStringFormats.CenterLeft);

                currentY += 25;

                // Draw a box around the amount in words
                double wordsBoxHeight = 25;

                graphics.DrawRectangle(
                    PdfSharp.Drawing.XPens.Black,
                    PdfSharp.Drawing.XBrushes.White,
                    margin, currentY, usableWidth, wordsBoxHeight);

                graphics.DrawString(netPaymentInWords, font,
                    PdfSharp.Drawing.XBrushes.Black,
                    new PdfSharp.Drawing.XRect(margin + 5, currentY + 3, usableWidth - 10, wordsBoxHeight - 6),
                    PdfSharp.Drawing.XStringFormats.CenterLeft);

                // Dispose graphics before saving
                graphics.Dispose();

                // Convert PDF to byte array
                byte[] pdfBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    document.Save(ms);
                    pdfBytes = ms.ToArray();
                }

                // Dispose document
                document.Dispose();

                // Return PDF file
                string filename = $"WagesSlipReport_Section{request.Id}_{request.Date:yyyyMM}.pdf";
                return File(pdfBytes, "application/pdf", filename);
            }
            catch (Exception ex)
            {
                // Log the error (consider using a proper logging framework)
                return BadRequest("Error generating PDF: " + ex.Message);
            }
        }









        [HttpPut]
        [Route("EUpdateInformation")]
        public async Task<IActionResult> UpdateInformation(EUpdateInformationRequest request)
        {
            UpdateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.UpdateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPut]
        [Route("WUpdateInformation")]
        public async Task<IActionResult> UpdateInformation(WUpdateInformationRequest request)
        {
            UpdateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.UpdateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPut]
        [Route("JUpdateInformation")]
        public async Task<IActionResult> UpdateInformation(JUpdateInformationRequest request)
        {
            UpdateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.UpdateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPut]
        [Route("SUpdateInformation")]
        public async Task<IActionResult> UpdateInformation(SUpdateInformationRequest request)
        {
            UpdateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.UpdateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPut]
        [Route("BSalUpdateInformation")]
        public async Task<IActionResult> UpdateInformation(BSalUpdateInformationRequest request)
        {
            UpdateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.UpdateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPut]
        [Route("OTUpdateInformation")]
        public async Task<IActionResult> UpdateInformation(OTUpdateInformationRequest request)
        {
            UpdateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.UpdateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPut]
        [Route("JSUpdateInformation")]
        public async Task<IActionResult> UpdateInformation(JSUpdateInformationRequest request)
        {
            UpdateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.UpdateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPut]
        [Route("LVTUpdateInformation")]
        public async Task<IActionResult> UpdateInformation(LVTUpdateInformationRequest request)
        {
            UpdateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.UpdateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPut]
        [Route("EmpATTUpdateInformation")]
        public async Task<IActionResult> UpdateInformation(EmpATTUpdateInformationRequest request)
        {
            UpdateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.UpdateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPut]
        [Route("WorkATTUpdateInformation")]
        public async Task<IActionResult> UpdateInformation(WorkATTUpdateInformationRequest request)
        {
            UpdateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.UpdateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPut]
        [Route("WagUpdateInformation")]
        public async Task<IActionResult> UpdateInformation(WagUpdateInformationRequest request)
        {
            UpdateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.UpdateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPut]
        [Route("WagSlipUpdateInformation")]
        public async Task<IActionResult> UpdateInformation(WagSlipUpdateInformationRequest request)
        {
            UpdateInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.UpdateInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }





        [HttpPost]
        [Route("EDeleteInformation")]
        public async Task<IActionResult> EDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.EDeleteInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPost]
        [Route("WDeleteInformation")]
        public async Task<IActionResult> WDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.WDeleteInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPost]
        [Route("JDeleteInformation")]
        public async Task<IActionResult> JDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.JDeleteInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPost]
        [Route("SDeleteInformation")]
        public async Task<IActionResult> SDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.SDeleteInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPost]
        [Route("JSDeleteInformation")]
        public async Task<IActionResult> JSDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.JSDeleteInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPost]
        [Route("LVTDeleteInformation")]
        public async Task<IActionResult> LVTDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.LVTDeleteInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);

        }
        [HttpPost]
        [Route("EmpATTDeleteInformation")]
        public async Task<IActionResult> EmpATTDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.EmpATTDeleteInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPost]
        [Route("WorkATTDeleteInformation")]
        public async Task<IActionResult> WorkATTDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse response = null;
            try
            {

                response = await _crudApplicationSL.WorkATTDeleteInformation(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }




        [HttpPost]
        [Route("ESearchInformationById")]
        public async Task<IActionResult> ESearchInformationById(ESearchInformationByIdRequest request)
        {
            SearchInformationByIdResponse response = null;
            try
            {

                response = await _crudApplicationSL.ESearchInformationById(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("SSearchInformationById")]
        public async Task<IActionResult> SSearchInformationById(ESearchInformationByIdRequest request)
        {
            SearchInformationByIdResponse response = null;
            try
            {

                response = await _crudApplicationSL.SSearchInformationById(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPost]
        [Route("BSalSearchBySection")]
        public async Task<IActionResult> BSalReadInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = null;
            try
            {

                response = await _crudApplicationSL.BSalReadInformationBySection(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPost]
        [Route("OTSearchBySection")]
        public async Task<IActionResult> OTReadInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = null;
            try
            {

                response = await _crudApplicationSL.OTReadInformationBySection(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        
        [HttpPost]
        [Route("WSlipSearchBySection")]
        public async Task<IActionResult> WSlipSearchInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = null;
            try
            {

                response = await _crudApplicationSL.WSlipSearchInformationBySection(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPost]
        [Route("WSlipReadBySection")]
        public async Task<IActionResult> WSlipReadInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = null;
            try
            {

                response = await _crudApplicationSL.WSlipReadInformationBySection(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("EmpATTSearchInformationById")]
        public async Task<IActionResult> EmpATTSearchInformationById(ESearchInformationByIdRequest request)
        {
            SearchInformationByIdResponse response = null;
            try
            {

                response = await _crudApplicationSL.EmpATTSearchInformationById(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("WorkATTSearchInformationById")]
        public async Task<IActionResult> WorkATTSearchInformationById(ESearchInformationByIdRequest request)
        {
            SearchInformationByIdResponse response = null;
            try
            {

                response = await _crudApplicationSL.WorkATTSearchInformationById(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }



        //[HttpPost]
        //[Route("WSearchInformationByJob")]
        //public async Task<IActionResult> WSearchInformationByJob(ESearchInformationByIdRequest request)
        //{
        //    SearchInformationByIdResponse response = null;
        //    try
        //    {

        //        response = await _crudApplicationSL.WSearchInformationByJob(request);

        //    }
        //    catch (Exception ex)
        //    {
        //        response.IsSuccess = false;
        //        response.Message = "Exception Message : " + ex.Message;
        //    }

        //    return Ok(response);
        //}
        [HttpPost]
        [Route("WSearchInformationBySection")]
        public async Task<IActionResult> WSearchInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = null;
            try
            {

                response = await _crudApplicationSL.WSearchInformationBySection(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPost]
        [Route("BSalSearchInformationBySection")]
        public async Task<IActionResult> BSalSearchInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = null;
            try
            {

                response = await _crudApplicationSL.BSalSearchInformationBySection(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }
        [HttpPost]
        [Route("OTSearchInformationBySection")]
        public async Task<IActionResult> OTSearchInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = null;
            try
            {

                response = await _crudApplicationSL.OTSearchInformationBySection(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }


        [HttpPost]
        [Route("JSearchInformationBySection")]
        public async Task<IActionResult> JSearchInformationBySection(ESearchInformationByIdRequest request)
        {
            SearchInformationByIdResponse response = null;
            try
            {

                response = await _crudApplicationSL.JSearchInformationBySection(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }





        [HttpPost]
        [Route("ESearchInformationByDate")]
        public async Task<IActionResult> ESearchInformationByDate(SearchInformationByDateRequest request)
        {
            SearchInformationByDateResponse response = null;
            try
            {

                response = await _crudApplicationSL.ESearchInformationByDate(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("EmpATTSearchInformationByDate")]
        public async Task<IActionResult> EmpATTSearchInformationByDate(SearchInformationByDateRequest request)
        {
            SearchInformationByDateResponse response = null;
            try
            {

                response = await _crudApplicationSL.EmpATTSearchInformationByDate(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("WorkATTSearchInformationByDate")]
        public async Task<IActionResult> WorkATTSearchInformationByDate(SearchInformationByDateRequest request)
        {
            SearchInformationByDateResponse response = null;
            try
            {

                response = await _crudApplicationSL.WorkATTSearchInformationByDate(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }

            return Ok(response);
        }

        //[HttpPost]
        //[Route("WageSearchInformationByDate")]
        //public async Task<IActionResult> WagSearchInformationByDate(SalarySearchByDateRequest request)
        //{
        //    SalarySearchByDateResponse response = null;
        //    try
        //    {

        //        response = await _crudApplicationSL.WagSearchInformationByDate(request);

        //    }
        //    catch (Exception ex)
        //    {
        //        response.IsSuccess = false;
        //        response.Message = "Exception Message : " + ex.Message;
        //    }

        //    return Ok(response);
        //}


    }
}
