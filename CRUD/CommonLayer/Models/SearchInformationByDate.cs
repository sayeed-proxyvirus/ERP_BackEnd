using System;

namespace CRUD.CommonLayer.Models
{
    public class SearchInformationByDate
    {

        public class SearchInformationByDateRequest
        {
            public DateOnly Day { get; set; }
        }

        public class SearchInformationByDateResponse
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
            public ESearchInformationByDate eSearchInformationByDate { get; set; }
            public EmpATTSearchInformationByDate empATTSearchInformationByDate { get; set; }
            public WorkATTSearchInformationByDate workATTSearchInformationByDate { get; set; }
            ///public WagSearchInformationByDate wagSearchInformationByDate { get; set; }
        }

        public class ESearchInformationByDate
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public string SectionName { get; set; }
            public string Jobname { get; set; }
            public DateOnly? JoinDate { get; set; }
            public string CardNo { get; set; }
            public string BankAcc { get; set; }
        }

        public class EmpATTSearchInformationByDate
        {
            public int EntryId { get; set; }
            
            public int EmpId { get; set; }
            
            public string EmpName { get; set; }
            public int SectionId { get; set; }
            public string CardNo { get; set; }
            public int Status { get; set; }
            public DateOnly Day { get; set; }
        }

        public class WorkATTSearchInformationByDate
        {
            public int EntryId { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public string SectionName { get; set; }
            public string JobName { get; set; }
            public string CardNo { get; set; }
            public int Status { get; set; }
            public DateOnly Day { get; set; }
        }
        //public class WagSearchInformationByDate
        //{
            
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public string SectionName { get; set; }
        //    public string JobName { get; set; }
        //    public string CardNo { get; set; }
        //    public int SalaryAmt { get; set; }
        //    public int Work_Day { get; set; }
        //    public int Other { get; set; }
        //    public int FestH { get; set; }
        //    public int We { get; set; }
        //    public int Sl { get; set; }
        //    public int Cl { get; set; }
        //    public int El { get; set; }
        //    public int Absent { get; set; }
        //    public int TDays { get; set; }
        //    public int Bonus { get; set; }
        //    public int Lwp { get; set; }
        //    public int Gross { get; set; }
        //    public int Net { get; set; }
        //    public decimal Deduct { get; set; }
        //    public int ACT_RE { get; set; }
        //    public string Month { get; set; }
        //}

    }
}
