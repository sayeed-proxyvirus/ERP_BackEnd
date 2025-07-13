using CRUD.CommonLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CRUD.CommonLayer.Models.SalarySearchByDate;
using static CRUD.CommonLayer.Models.SearchInformationByDate;

namespace CRUD.RepositoryLayer
{
    public interface ICrudAppliactionRL
    {


        public Task<LoginResponse> Login(LoginRequest request);
        public Task<RegisterResponse> Register(RegisterRequest request);


        public Task<CreateInformationResponse> CreateInformation(ECreateInformationRequest request);
        public Task<CreateInformationResponse> CreateInformation(WCreateInformationRequest request);
        public Task<CreateInformationResponse> CreateInformation(JCreateInformationRequest request);
        public Task<CreateInformationResponse> CreateInformation(JSCreateInformationRequest request);
        public Task<CreateInformationResponse> CreateInformation(LVTCreateInformationRequest request);
        public Task<CreateInformationResponse> CreateInformation(EmpATTCreateInformationRequest request);
        public Task<CreateInformationResponse> CreateInformation(WorkerATTCreateInformationRequest request);



        public Task<EReadInformationResponse> EReadInformation();
        public Task<EReadInformationResponse> WReadInformation();
        public Task<EReadInformationResponse> JReadInformation();
        public Task<EReadInformationResponse> SReadInformation();
        public Task<EReadInformationResponse> JSReadInformation();
        public Task<EReadInformationResponse> ECReadInformation();
        public Task<EReadInformationResponse> WCReadInformation();
        public Task<EReadInformationResponse> JCReadInformation();
        
        public Task<EReadInformationResponse> JSCReadInformation();
        public Task<EReadInformationResponse> BReadInformation();
        
        public Task<EReadInformationResponse> LVTReadInformation();
        public Task<EReadInformationResponse> WagReadInformation();


        public Task<UpdateInformationResponse> UpdateInformation(EUpdateInformationRequest request);
        public Task<UpdateInformationResponse> UpdateInformation(WUpdateInformationRequest request);
        public Task<UpdateInformationResponse> UpdateInformation(JUpdateInformationRequest request);
        public Task<UpdateInformationResponse> UpdateInformation(SUpdateInformationRequest request);
        public Task<UpdateInformationResponse> UpdateInformation(BSalUpdateInformationRequest request);
        public Task<UpdateInformationResponse> UpdateInformation(OTUpdateInformationRequest request);
        public Task<UpdateInformationResponse> UpdateInformation(JSUpdateInformationRequest request);
        public Task<UpdateInformationResponse> UpdateInformation(LVTUpdateInformationRequest request);
        public Task<UpdateInformationResponse> UpdateInformation(EmpATTUpdateInformationRequest request);
        public Task<UpdateInformationResponse> UpdateInformation(WorkATTUpdateInformationRequest request);
        public Task<UpdateInformationResponse> UpdateInformation(WagUpdateInformationRequest request);
        public Task<UpdateInformationResponse> UpdateInformation(WagSlipUpdateInformationRequest request);


        public Task<DeleteInformationResponse> EDeleteInformation(DeleteInformationRequest request);
        public Task<DeleteInformationResponse> WDeleteInformation(DeleteInformationRequest response);
        public Task<DeleteInformationResponse> JDeleteInformation(DeleteInformationRequest response);
        public Task<DeleteInformationResponse> SDeleteInformation(DeleteInformationRequest response);
        public Task<DeleteInformationResponse> JSDeleteInformation(DeleteInformationRequest response);
        public Task<DeleteInformationResponse> LVTDeleteInformation(DeleteInformationRequest response);
        public Task<DeleteInformationResponse> EmpATTDeleteInformation(DeleteInformationRequest response);
        public Task<DeleteInformationResponse> WorkATTDeleteInformation(DeleteInformationRequest response);



        public Task<SearchInformationByIdResponse> ESearchInformationById(ESearchInformationByIdRequest request);
        
        public Task<SearchInformationByIdResponse> EmpATTSearchInformationById(ESearchInformationByIdRequest request);
        public Task<SearchInformationByIdResponse> WorkATTSearchInformationById(ESearchInformationByIdRequest request);
        public Task<SearchInformationByIdResponse> SSearchInformationById(ESearchInformationByIdRequest request);
        public Task<SearchInformationByIdResponse> JSearchInformationBySection(ESearchInformationByIdRequest request);
        //public Task<SearchInformationByIdResponse> WSearchInformationByJob(ESearchInformationByIdRequest request);



        public Task<SalarySearchByDateResponse> WSearchInformationBySection(SalarySearchByDateRequest request);
        public Task<SalarySearchByDateResponse> WSlipSearchInformationBySection(SalarySearchByDateRequest request);
        public Task<SalarySearchByDateResponse> WSlipReadInformationBySection(SalarySearchByDateRequest request);
        public Task<SalarySearchByDateResponse> BSalSearchInformationBySection(SalarySearchByDateRequest request);
        public Task<SalarySearchByDateResponse> OTSearchInformationBySection(SalarySearchByDateRequest request);
        public Task<SalarySearchByDateResponse> BSalReadInformationBySection(SalarySearchByDateRequest request);
        public Task<SalarySearchByDateResponse> OTReadInformationBySection(SalarySearchByDateRequest request);



        


        public Task<SearchInformationByDateResponse> ESearchInformationByDate(SearchInformationByDateRequest request);
        public Task<SearchInformationByDateResponse> EmpATTSearchInformationByDate(SearchInformationByDateRequest request);
        public Task<SearchInformationByDateResponse> WorkATTSearchInformationByDate(SearchInformationByDateRequest request);
        //public Task<SalarySearchByDateResponse> WagSearchInformationByDate(SalarySearchByDateRequest request); 
    }
}
