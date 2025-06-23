using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace CRUD.CommonLayer.Models
{
    public class ESearchInformationByIdRequest
    {
        public int Id { get; set; }
    }

    public class SearchInformationByIdResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public ESearchInformationById esearchInformationById { get; set; }
        public SSearchInformationById ssearchInformationById { get; set; }
        public EmpATTSearchInformationById empATTSearchInformationById { get; set; }
        public WorkATTSearchInformationById workATTSearchInformationById { get; set; }
        //public List<WSearchInformationByJob>  wsearchInformationByJob { get; set; }
        public List<JSearchInformationBySection> jSearchInformationBySections { get; set; }
        
    }

    public class ESearchInformationById
    {
        //public int EmpId { get; set; }
        public string Name { get; set; }
        public string SectionName { get; set; }
        public string Jobname { get; set; }
        //public DateOnly? JoinDate { get; set; }
        public string CardNo { get; set; }
        public string BankAcc { get; set; }
    }

    public class SSearchInformationById
    {
        //public int Id { get; set; }
        public int SalaryAmt { get; set; }
        public DateOnly? Updt { get; set; }
        
    }

    //public class WSearchInformationByJob
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string SectionName { get; set; }

    //    /// <summary>
    //    /// public string JobId{ get; set; }
    //    /// </summary>
    //    public DateOnly? JoinDate { get; set; }
    //    public string CardNo { get; set; }
    //    public string BankAC { get; set; }
    //    public int Grade { get; set; }
    //}
    

    public class JSearchInformationBySection 
    {
        public int JobId { get; set; }
        /// <summary>
        /// public int SectionId { get; set; }
        /// </summary>
        public string  JobName { get; set; }
        public int Att_Bonus { get; set; }
        public int Food { get; set; }
        public int Grade { get; set; }
    }


    public class EmpATTSearchInformationById
    {
        public int EntryId { get; set; }
        /// <summary>
        /// public int EmpId { get; set; }
        /// </summary>
        public string EmpName { get; set; }
        public int SectionId { get; set; }
        public string CardNo { get; set; }
        public int Status { get; set; }
        public DateOnly Day { get; set; }
    }

   
    public class WorkATTSearchInformationById
    {
        public int EntryId { get; set; }
        /// <summary>
        /// public int Id { get; set; }
        /// </summary>
        public string Name { get; set; }
        public string SectionName { get; set; }
        public string JobName { get; set; }
        public string CardNo { get; set; }
        public int Status { get; set; }
        public DateOnly Day { get; set; }
    }



}
