using CRUD.CommonLayer.Models;
using CRUD.RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CRUD.CommonLayer.Models.SalarySearchByDate;
using static CRUD.CommonLayer.Models.SearchInformationByDate;

namespace CRUD.ServiceLayer
{
    public class CrudAppliactionSL : ICrudAppliactionSL
    {
        public readonly ICrudAppliactionRL _crudAppliactionRL;
        public CrudAppliactionSL(ICrudAppliactionRL crudAppliactionRL)
        {
            _crudAppliactionRL = crudAppliactionRL;
        }


        public async Task<LoginResponse> Login(LoginRequest request)
        {
            return await _crudAppliactionRL.Login(request);
        }
        public async Task<RegisterResponse> Register(RegisterRequest request)
        {
            return await _crudAppliactionRL.Register(request);
        }

        public async Task<CreateInformationResponse> CreateInformation(ECreateInformationRequest request)
        {

            return await _crudAppliactionRL.CreateInformation(request);
            
        }

        public async Task<CreateInformationResponse> CreateInformation(WCreateInformationRequest request)
        {

            return await _crudAppliactionRL.CreateInformation(request);

        }

        public async Task<CreateInformationResponse> CreateInformation(JCreateInformationRequest request)
        {

            return await _crudAppliactionRL.CreateInformation(request);

        }

        


        public async Task<CreateInformationResponse> CreateInformation(JSCreateInformationRequest request)
        {

            return await _crudAppliactionRL.CreateInformation(request);

        }


        public async Task<CreateInformationResponse> CreateInformation(LVTCreateInformationRequest request)
        {

            return await _crudAppliactionRL.CreateInformation(request);

        }


        public async Task<CreateInformationResponse> CreateInformation(EmpATTCreateInformationRequest request)
        {

            return await _crudAppliactionRL.CreateInformation(request);

        }

        public async Task<CreateInformationResponse> CreateInformation(WorkerATTCreateInformationRequest request)
        {

            return await _crudAppliactionRL.CreateInformation(request);

        }


        public async Task<EReadInformationResponse> EReadInformation()
        {
            return await _crudAppliactionRL.EReadInformation(); 
        }

        public async Task<EReadInformationResponse> WReadInformation()
        {
            return await _crudAppliactionRL.WReadInformation();
        }

        public async Task<EReadInformationResponse> JReadInformation()
        {
            return await _crudAppliactionRL.JReadInformation();
        }

        public async Task<EReadInformationResponse> SReadInformation()
        {
            return await _crudAppliactionRL.SReadInformation();
        }

        public async Task<EReadInformationResponse> JSReadInformation()
        {
            return await _crudAppliactionRL.JSReadInformation();
        }
        public async Task<EReadInformationResponse> ECReadInformation()
        {
            return await _crudAppliactionRL.ECReadInformation();
        }

        public async Task<EReadInformationResponse> WCReadInformation()
        {
            return await _crudAppliactionRL.WCReadInformation();
        }

        public async Task<EReadInformationResponse> JCReadInformation()
        {
            return await _crudAppliactionRL.JCReadInformation();
        }

        

        public async Task<EReadInformationResponse> JSCReadInformation()
        {
            return await _crudAppliactionRL.JSCReadInformation();
        }
        public async Task<EReadInformationResponse> BReadInformation()
        {
            return await _crudAppliactionRL.BReadInformation();
        }
        

        public async Task<EReadInformationResponse> LVTReadInformation()
        {
            return await _crudAppliactionRL.LVTReadInformation();
        }
        public async Task<EReadInformationResponse> WagReadInformation()
        {
            return await _crudAppliactionRL.WagReadInformation();
        }



        public async Task<UpdateInformationResponse> UpdateInformation(EUpdateInformationRequest request)
        {
            return await _crudAppliactionRL.UpdateInformation(request);
        }
        public async Task<UpdateInformationResponse> UpdateInformation(WUpdateInformationRequest request)
        {
            return await _crudAppliactionRL.UpdateInformation(request);
        }
        public async Task<UpdateInformationResponse> UpdateInformation(JUpdateInformationRequest request)
        {
            return await _crudAppliactionRL.UpdateInformation(request);
        }
        public async Task<UpdateInformationResponse> UpdateInformation(SUpdateInformationRequest request)
        {
            return await _crudAppliactionRL.UpdateInformation(request); 
        }
        public async Task<UpdateInformationResponse> UpdateInformation(BSalUpdateInformationRequest request)
        {
            return await _crudAppliactionRL.UpdateInformation(request); 
        }
        public async Task<UpdateInformationResponse> UpdateInformation(OTUpdateInformationRequest request)
        {
            return await _crudAppliactionRL.UpdateInformation(request);
        }
        public async Task<UpdateInformationResponse> UpdateInformation(JSUpdateInformationRequest request)
        {
            return await _crudAppliactionRL.UpdateInformation(request);
        }
        public async Task<UpdateInformationResponse> UpdateInformation(LVTUpdateInformationRequest request)
        {
            return await _crudAppliactionRL.UpdateInformation(request);
        }
        public async Task<UpdateInformationResponse> UpdateInformation(EmpATTUpdateInformationRequest request)
        {
            return await _crudAppliactionRL.UpdateInformation(request);
        }
        public async Task<UpdateInformationResponse> UpdateInformation(WorkATTUpdateInformationRequest request)
        {
            return await _crudAppliactionRL.UpdateInformation(request);
        }
        public async Task<UpdateInformationResponse> UpdateInformation(WagUpdateInformationRequest request)
        {
            return await _crudAppliactionRL.UpdateInformation(request);
        }
        public async Task<UpdateInformationResponse> UpdateInformation(WagSlipUpdateInformationRequest request)
        {
            return await _crudAppliactionRL.UpdateInformation(request);
        }


        public async Task<DeleteInformationResponse> EDeleteInformation(DeleteInformationRequest request)
        {
            return await _crudAppliactionRL.EDeleteInformation(request);
        }
        public async Task<DeleteInformationResponse> WDeleteInformation(DeleteInformationRequest request)
        {
            return await _crudAppliactionRL.WDeleteInformation(request);
        }
        public async Task<DeleteInformationResponse> JDeleteInformation(DeleteInformationRequest request)
        {
            return await _crudAppliactionRL.JDeleteInformation(request);
        }
        public async Task<DeleteInformationResponse> SDeleteInformation(DeleteInformationRequest request)
        {
            return await _crudAppliactionRL.SDeleteInformation(request);
        }
        public async Task<DeleteInformationResponse> JSDeleteInformation(DeleteInformationRequest request)
        {
            return await _crudAppliactionRL.JSDeleteInformation(request);
        }
        public async Task<DeleteInformationResponse> LVTDeleteInformation(DeleteInformationRequest request)
        {
            return await _crudAppliactionRL.LVTDeleteInformation(request);
        }
        public async Task<DeleteInformationResponse> EmpATTDeleteInformation(DeleteInformationRequest request)
        {
            return await _crudAppliactionRL.EmpATTDeleteInformation(request);
        }

        public async Task<DeleteInformationResponse> WorkATTDeleteInformation(DeleteInformationRequest request)
        {
            return await _crudAppliactionRL.WorkATTDeleteInformation(request);
        }


        public async Task<SearchInformationByIdResponse> ESearchInformationById(ESearchInformationByIdRequest request)
        {
            return await _crudAppliactionRL.ESearchInformationById(request);
        }
        public async Task<SearchInformationByIdResponse> SSearchInformationById(ESearchInformationByIdRequest request)
        {
            return await _crudAppliactionRL.SSearchInformationById(request);
        }
        public async Task<SearchInformationByIdResponse> EmpATTSearchInformationById(ESearchInformationByIdRequest request)
        {
            return await _crudAppliactionRL.EmpATTSearchInformationById(request);
        }
        public async Task<SearchInformationByIdResponse> WorkATTSearchInformationById(ESearchInformationByIdRequest request)
        {
            return await _crudAppliactionRL.WorkATTSearchInformationById(request);
        }

        //public async Task<SearchInformationByIdResponse> WSearchInformationByJob(ESearchInformationByIdRequest request) 
        //{
        //    return await _crudAppliactionRL.WSearchInformationByJob(request);
        //}

        public async Task<SalarySearchByDateResponse> WSearchInformationBySection(SalarySearchByDateRequest request)
        {
            return await _crudAppliactionRL.WSearchInformationBySection(request);
        }
        public async Task<SalarySearchByDateResponse> WSlipSearchInformationBySection(SalarySearchByDateRequest request)
        {
            return await _crudAppliactionRL.WSlipSearchInformationBySection(request);
        }
        public async Task<SalarySearchByDateResponse> WSlipReadInformationBySection(SalarySearchByDateRequest request)
        {
            return await _crudAppliactionRL.WSlipReadInformationBySection(request);
        }
        public async Task<SalarySearchByDateResponse> BSalSearchInformationBySection(SalarySearchByDateRequest request)
        {
            return await _crudAppliactionRL.BSalSearchInformationBySection(request);
        }
        public async Task<SalarySearchByDateResponse> OTSearchInformationBySection(SalarySearchByDateRequest request)
        {
            return await _crudAppliactionRL.OTSearchInformationBySection(request);
        }

        public async Task<SearchInformationByIdResponse> JSearchInformationBySection(ESearchInformationByIdRequest request)
        {
            return await _crudAppliactionRL.JSearchInformationBySection(request);
        }
        public async Task<SalarySearchByDateResponse> BSalReadInformationBySection(SalarySearchByDateRequest request)
        {
            return await _crudAppliactionRL.BSalReadInformationBySection(request);
        }
        public async Task<SalarySearchByDateResponse> OTReadInformationBySection(SalarySearchByDateRequest request)
        {
            return await _crudAppliactionRL.OTReadInformationBySection(request);
        }



        public async Task<SearchInformationByDateResponse> ESearchInformationByDate(SearchInformationByDateRequest request)
        {
            return await _crudAppliactionRL.ESearchInformationByDate(request);
        }
        public async Task<SearchInformationByDateResponse> EmpATTSearchInformationByDate(SearchInformationByDateRequest request)
        {
            return await _crudAppliactionRL.EmpATTSearchInformationByDate(request);
        }
        public async Task<SearchInformationByDateResponse> WorkATTSearchInformationByDate(SearchInformationByDateRequest request)
        {
            return await _crudAppliactionRL.WorkATTSearchInformationByDate(request);
        }

        //public async Task<SalarySearchByDateResponse> WagSearchInformationByDate(SalarySearchByDateRequest request)
        //{
        //    return await _crudAppliactionRL.WagSearchInformationByDate(request);
        //}
    }
}
