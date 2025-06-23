using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.CommonLayer.Models
{
    public class EUpdateInformationRequest
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string SectionName { get; set; }
        public string Jobname { get; set; }
        public DateOnly? JoinDate { get; set; }
        public string CardNo { get; set; }
        public string BankAcc { get; set; }
    }

    public class WUpdateInformationRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SectionName { get; set; }
        public string JobName { get; set; }
        public string CardNo { get; set; }
        public int BankAC { get; set; }
        public DateOnly JoinDate { get; set; }
        public int Grade { get; set; }
    }

    public class SUpdateInformationRequest
    {
        public int Id { get; set; }


        public DateOnly Update_date { get; set; }
        public int Salary_Amount { get; set; }
    }



    public class JUpdateInformationRequest
    {
        public int JobId { get; set; }
        public int SectionsId { get; set; }
        public string JobName { get; set; }
        public int Grade { get; set; }
        public int Att_Bonus { get; set; }
        public int Food { get; set; }
    }

    public class JSUpdateInformationRequest
    {
        public int SectionsId { get; set; }
        public string SectionsName { get; set; }
    }

    public class LVTUpdateInformationRequest
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int Valid_days { get; set; }
    }

    public class EmpATTUpdateInformationRequest
    {
        public int EntryId { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int SectionId { get; set; }
        public string CardNo { get; set; }
        public int Status { get; set; }
        public DateOnly Day { get; set; }
    }
    public class WorkATTUpdateInformationRequest
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

    public class UpdateInformationResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }


    public class BSalUpdateInformationRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SectionName { get; set; }

        public string JobName { get; set; }
        public string BType { get; set; }
        public string CardNo { get; set; }
        public string BankAC { get; set; }


        public int Bonus { get; set; }

        public int Gross { get; set; }
        public int Net { get; set; }
        public int Deduct { get; set; }


    }

    public class OTUpdateInformationRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SectionName { get; set; }

        public string JobName { get; set; }
        public string Month { get; set; }
        public string CardNo { get; set; }
        public string BankAC { get; set; }


        public decimal Hour { get; set; }
        public decimal ExHour { get; set; }

        public int Gross { get; set; }
        public int Net_OT { get; set; }
        public int Deduct { get; set; }


    }

    public class WagUpdateInformationRequest
    {
        public int Id { get; set; }
        public int SalaryAmt { get; set; }
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
        //public decimal ACT_RE { get; set; }
        public string Month { get; set; }
    }

    public class WagSlipUpdateInformationRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SectionName { get; set; }
        public string JobName { get; set; }
        public string BankAcc { get; set; }
        public string CardNo { get; set; }
        public int OT_hours { get; set; }
        public int OT_Amount { get; set; }
        public int Grade { get; set; }
        public int Basic { get; set; }
        public int Medical { get; set; }
        public int Conv { get; set; }
        public int Food { get; set; }
        public int HR { get; set; }
        public int Days { get; set; }
        public int Att_Bonus { get; set; }
        public int Rate { get; set; }
        public int Gross_Wages { get; set; }
        public int Net_Pay { get; set; }
        public int Wages { get; set; }
        public int Net_Wages { get; set; }
        public decimal Deduct { get; set; }
        
        public string Month { get; set; }
    }
}
