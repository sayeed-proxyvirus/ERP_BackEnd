using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.CommonLayer.Models
{
    public class ECreateInformationRequest
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string SectionName { get; set; }
        public string Jobname { get; set; }
        public DateOnly? JoinDate { get; set; }
        public string CardNo { get; set; }
        public string BankAcc { get; set; }
    }

    public class WCreateInformationRequest 
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

    


    public class JCreateInformationRequest
    {
        public int JobId { get; set; }
        public int SectionsId { get; set; }
        public string JobName { get; set; }
        public int Grade { get; set; }
        public int Att_Bonus { get; set; }
        public int Food { get; set; }
    }

    public class JSCreateInformationRequest
    {
        public int SectionsId { get; set; }
        public string SectionsName { get; set; }

        
    }

    public class LVTCreateInformationRequest 
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int Valid_days { get; set; }
    }

    public class EmpATTCreateInformationRequest
    {
        public int EntryId { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int SectionId { get; set; }
        public string CardNo { get; set; }
        public int Status { get; set; }
        public DateOnly Day { get; set; }
    }

    public class WorkerATTCreateInformationRequest
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


    public class CreateInformationResponse
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }
    }
}
