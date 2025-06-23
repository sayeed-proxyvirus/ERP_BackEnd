using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using static CRUD.CommonLayer.Models.SearchInformationByDate;

namespace CRUD.CommonLayer.Models
{
    public class SalarySearchByDate
    {
        public class SalarySearchByDateRequest 
        {
            public string Date { get; set;}
            public int Id { get; set; }
            
        }
        public class SalarySearchByDateResponse
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
            public List<WSearchInformationBySection> wsearchInformationBySection { get; set; }
            public List<WSlipSearchInformationBySection> wslipsearchInformationBySection { get; set; }
            public List<WSlipReadInformationBySection> wslipreadInformationBySection { get; set; }
            public List<BSalSearchInformationBySection> bsalsearchInformationBySection { get; set; }
            public List<BSalReadInformationBySection> bsalreadInformationBySection { get; set; }
            public List<OTSearchInformationBySection> otsearchInformationBySection { get; set; }
            public List<OTReadInformationBySection> otreadInformationBySection { get; set; }

        }
        public class WSearchInformationBySection
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public string SectionName { get; set; }
            //public string  Month { get; set; }
            public string JobName { get; set; }
            //public DateOnly? JoinDate { get; set; }
            public string CardNo { get; set; }
            public string BankAC { get; set; }
            public int Salary { get; set; }

            public int Work_Day { get; set; }
            public int Other { get; set; }
            public int FestH { get; set; }
            public int We { get; set; }
            public int Sl { get; set; }
            public int Cl { get; set; }
            public int El { get; set; }
            public int Absent { get; set; }
            public int TDays { get; set; }
            public int Bonus { get; set; }
            public int Lwp { get; set; }
            public int Gross { get; set; }
            public int Net { get; set; }
            public decimal Deduct { get; set; }
            public int ACT_RE { get; set; }

        }

        public class BSalReadInformationBySection
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string SectionName { get; set; }
            public string JobName { get; set; }
            public string CardNo { get; set; }
            public string BankAcc { get; set; }
            public int Salary { get; set; }
            public int Bonus { get; set; }
            public int Gross { get; set; }
            public int Deduct { get; set; }
            public DateOnly PayDate { get; set; }
        }
        public class BSalSearchInformationBySection
        {
            //public int Id { get; set; }
            public string Name { get; set; }

            //public string SectionName { get; set; }

            public string JobName { get; set; }
            public string BType { get; set; }
            public string CardNo { get; set; }
            public string BankAC { get; set; }


            public int Bonus { get; set; }

            public int Gross { get; set; }
            public int Net { get; set; }
            public int Deduct { get; set; }


        }


        public class WSlipSearchInformationBySection
        {
            //public int Id { get; set; }
            public string Name { get; set; }
            //public string SectionName { get; set; }
            public string Month { get; set; }
            public string JobName { get; set; }
            public string CardNo { get; set; }
            public string BankAcc { get; set; }
            public int Wages { get; set; }
            public int Days { get; set; }
            public int Grade { get; set; }
            public int Basic { get; set; }
            public int HR { get; set; }
            public int Food { get; set; }
            public int Conv { get; set; }
            public int Medical { get; set; }
            public int OT_Hours { get; set; }
            public int OT_Amount { get; set; }
            public int Rate { get; set; }
            public int Att_Bonus { get; set; }
            public int Gross_Wages { get; set; }
            public int Net_Pay { get; set; }
            public decimal Deduct { get; set; }
            //public int ACT_RE { get; set; }
            public int Net_Wages { get; set; }

        }
        public class WSlipReadInformationBySection
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string SectionName { get; set; }
            public string Month { get; set; }
            public string JobName { get; set; }
            public string CardNo { get; set; }
            public string BankAcc { get; set; }
            public int Wages { get; set; }
            public int Days { get; set; }
            public int Grade { get; set; }
            public int Basic { get; set; }
            public int HR { get; set; }
            public int Food { get; set; }
            public int Conv { get; set; }
            public int Medical { get; set; }
            public int OT_Hours { get; set; }
            public int OT_Amount { get; set; }
            public int Rate { get; set; }
            public int Att_Bonus { get; set; }
            public int Gross_Wages { get; set; }
            public int Net_Pay { get; set; }
            public decimal Deduct { get; set; }
            //public int ACT_RE { get; set; }
            public int Net_Wages { get; set; }

        }


        public class OTReadInformationBySection
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string SectionName { get; set; }
            public string JobName { get; set; }
            public string CardNo { get; set; }
            public string BankAcc { get; set; }
            public int Salary { get; set; }
            public decimal Hour { get; set; }
            public decimal ExHour { get; set; }
            public int Gross { get; set; }
            public int Deduct { get; set; }
            public DateOnly PayDate { get; set; }
        }
        public class OTSearchInformationBySection
        {
            //public int Id { get; set; }
            public string Name { get; set; }

            //public string SectionName { get; set; }

            public string JobName { get; set; }
            public string Month { get; set; }
            public string CardNo { get; set; }
            public string BankAC { get; set; }


            public decimal Hour { get; set; }
            //public decimal ExHour { get; set; }
            public int Gross { get; set; }
            public int Net_OT { get; set; }
            public int Deduct { get; set; }


        }
    }
}
