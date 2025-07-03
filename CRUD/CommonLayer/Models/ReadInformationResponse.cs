using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace CRUD.CommonLayer.Models
{
    public class EReadInformationResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<EReadInformation> ereadInformation { get; set; }
        public List<ECReadInformation> ecreadInformation { get; set; }
        public List<WReadInformation> wreadInformation { get; set; }
        public List<WCReadInformation> wcreadInformation { get; set; }
        public List<JReadInformation> jreadInformation { get; set; }
        public List<JCReadInformation> jcreadInformation { get; set; }
        public List<JSReadInformation> jsreadInformation { get; set; }
        public List<JSCReadInformation> jscreadInformation { get; set; }
        public List<BReadInformation> breadInformation { get; set; }
        
        public List<LVTReadInformation> lvtreadInformation { get; set; }
        public List<WagReadInformation> wagreadInformation { get; set; }
        public List<SReadInformation> sreadInformation { get; set; }

    }

    public class EReadInformation
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string SectionName { get; set; }
        public string Jobname { get; set; }
        public DateOnly JoinDate { get; set; }
        public string CardNo { get; set; }
        public string BankAcc { get; set; }
        
    }
    public class ECReadInformation
    {
        public int Count { get; set; }

    }

    public class WReadInformation
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

    public class WCReadInformation
    {
        public int Count { get; set; }

    }

    public class SReadInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CardNo { get; set; }
        public string SectionName { get; set; }
        public string JobName { get; set; }

        public DateOnly Update_date { get; set; }
        public int Salary_Amount { get; set; }
    }


    public class JReadInformation
    {
        public int JobId { get; set; }
        public int SectionsId { get; set; }
        public string JobName { get; set; }
        public int Grade { get; set; }
        public int Att_Bonus { get; set; }
        public int Food { get; set; }
    }

    public class JCReadInformation
    {
        public int Count { get; set; }

    }


    public class JSReadInformation
    {
        public int SectionsId { get; set; }
        public string SectionsName { get; set; }
    }

    public class JSCReadInformation
    {
        public int Count { get; set; }

    }


    public class BReadInformation
    {
        public int Bcode { get; set; }
        public string Btype { get; set; }
    }
    

    public class LVTReadInformation
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int Valid_days { get; set; }
    }
    public class WagReadInformation 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CardNo { get; set; }
        public string SectionName { get; set; }
        public string JobName { get; set; }
        public int BankAcc { get; set; }
        
    }




}
