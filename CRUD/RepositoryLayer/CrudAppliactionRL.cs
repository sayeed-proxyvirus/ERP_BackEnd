using CRUD.CommonLayer.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using static CRUD.CommonLayer.Models.SearchInformationByDate;
using static CRUD.CommonLayer.Models.SalarySearchByDate;

namespace CRUD.RepositoryLayer
{
    public class CrudAppliactionRL : ICrudAppliactionRL
    {
        public readonly IConfiguration _configuration;
        public readonly SqlConnection _sqlConnection;
        int ConnectionTimeOut = 1800;
        public CrudAppliactionRL(IConfiguration configuration)
        {
            _configuration = configuration;
            _sqlConnection = new SqlConnection(_configuration["ConnectionStrings:SqlServerDBConnection"]);
            //_mySqlConnection = new MySqlConnection(_configuration["ConnectionStrings:MySqlDBConnection"]);
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            LoginResponse response = new LoginResponse();
            response.IsSuccess = true;
            response.Message = "Successful";
            try
            {
                string StoredProcedure = "usp_login";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.SearchInformationById, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoredProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@EmpName", request.UserName);
                    sqlCommand.Parameters.AddWithValue("CardNo", request.Password);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            await _sqlDataReader.ReadAsync();
                            //response.esearchInformationById = new ESearchInformationById();
                            //response.esearchInformationById.EmpName = _sqlDataReader["EmpName"] != DBNull.Value ? _sqlDataReader["EmpName"].ToString() : string.Empty;
                            //response.esearchInformationById.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
                            //response.esearchInformationById.JoinDate = _sqlDataReader["JoinDate"] == DBNull.Value ? Convert.ToDateTime(null) : Convert.ToDateTime(_sqlDataReader["JoinDate"]);
                            //response.esearchInformationById.EmpName = _sqlDataReader["EmpName"] != DBNull.Value ? _sqlDataReader["EmpName"].ToString() : string.Empty;
                            //response.esearchInformationById.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                            //response.esearchInformationById.BankAcc = _sqlDataReader["BankAcc"] != DBNull.Value ? _sqlDataReader["BankAcc"].ToString() : string.Empty;
                            response.Message = "Login Successfull!!!";


                        }
                        else
                        {
                            response.Message = "No data Found";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }


        public async Task<CreateInformationResponse> CreateInformation(ECreateInformationRequest request)
        {
            CreateInformationResponse resposne = new CreateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                //if (_mySqlConnection != null)
                if(_sqlConnection != null)
                {
                    string StoreProcedure = "usp_register";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.CreateInformationQuery, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@EmpName", request.EmpName);
                        sqlCommand.Parameters.AddWithValue("@SectionName", request.SectionName);
                        sqlCommand.Parameters.AddWithValue("@JobName", request.Jobname);
                        sqlCommand.Parameters.AddWithValue("@JoinDate", request.JoinDate);
                        sqlCommand.Parameters.AddWithValue("@CardNo", request.CardNo);
                        sqlCommand.Parameters.AddWithValue("@BankAcc", request.BankAcc);

                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "CreateInformation Not Executed";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<CreateInformationResponse> CreateInformation(WCreateInformationRequest request)
        {
            CreateInformationResponse resposne = new CreateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                //if (_mySqlConnection != null)
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_AddWorker";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.CreateInformationQuery, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@Name", request.Name);
                        sqlCommand.Parameters.AddWithValue("@SectionName", request.SectionName);
                        sqlCommand.Parameters.AddWithValue("@JobName", request.JobName);
                        sqlCommand.Parameters.AddWithValue("@JoinDate", request.JoinDate);
                        sqlCommand.Parameters.AddWithValue("@CardNo", request.CardNo);
                        sqlCommand.Parameters.AddWithValue("@BankAC", request.BankAC);
                        sqlCommand.Parameters.AddWithValue("@Grade", request.Grade);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "CreateInformation Not Executed";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<CreateInformationResponse> CreateInformation(JCreateInformationRequest request)
        {
            CreateInformationResponse resposne = new CreateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                //if (_mySqlConnection != null)
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_AddJob";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.CreateInformationQuery, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@SectionsId", request.SectionsId);
                        sqlCommand.Parameters.AddWithValue("@JobName", request.JobName);
                        sqlCommand.Parameters.AddWithValue("@Grade", request.Grade);
                        sqlCommand.Parameters.AddWithValue("@Att_Bonus", request.Grade);
                        sqlCommand.Parameters.AddWithValue("@Food", request.Food);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "CreateInformation Not Executed";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<CreateInformationResponse> CreateInformation(JSCreateInformationRequest request)
        {
            CreateInformationResponse resposne = new CreateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                //if (_mySqlConnection != null)
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_AddSec";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.CreateInformationQuery, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@SectionsName", request.SectionsName);
                        
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "CreateInformation Not Executed";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<CreateInformationResponse> CreateInformation(LVTCreateInformationRequest request)
        {
            CreateInformationResponse resposne = new CreateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                //if (_mySqlConnection != null)
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_AddLevTyp";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.CreateInformationQuery, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@Status", request.Status);
                        sqlCommand.Parameters.AddWithValue("@Valid_days", request.Valid_days);

                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "CreateInformation Not Executed";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<CreateInformationResponse> CreateInformation(EmpATTCreateInformationRequest request)
        {
            CreateInformationResponse resposne = new CreateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                //if (_mySqlConnection != null)
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_AddEmpAtt";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.CreateInformationQuery, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@EmpId", request.EmpId);
                        sqlCommand.Parameters.AddWithValue("@EmpName", request.EmpName);
                        sqlCommand.Parameters.AddWithValue("@SectionsId", request.SectionId);
                        sqlCommand.Parameters.AddWithValue("@CardNo", request.CardNo);
                        sqlCommand.Parameters.AddWithValue("@Status", request.Status);
                        sqlCommand.Parameters.AddWithValue("@Day", request.Day);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "CreateInformation Not Executed";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<CreateInformationResponse> CreateInformation(WorkerATTCreateInformationRequest request)
        {
            CreateInformationResponse resposne = new CreateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                //if (_mySqlConnection != null)
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_AddWorkAtt";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.CreateInformationQuery, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        sqlCommand.Parameters.AddWithValue("@Name", request.Name);
                        sqlCommand.Parameters.AddWithValue("@SectionName", request.SectionName);
                        sqlCommand.Parameters.AddWithValue("@JobName", request.JobName);
                        sqlCommand.Parameters.AddWithValue("@CardNo", request.CardNo);
                        sqlCommand.Parameters.AddWithValue("@Status", request.Status);
                        sqlCommand.Parameters.AddWithValue("@Day", request.Day);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "CreateInformation Not Executed";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }



        public async Task<EReadInformationResponse> EReadInformation()
        {
            EReadInformationResponse response = new EReadInformationResponse();
            response.ereadInformation = new List<EReadInformation>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_ViewEmp";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using(SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                EReadInformation getResponse = new EReadInformation();
                                getResponse.EmpId = _sqlDataReader["EmpId"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["EmpId"]) : 0;
                                getResponse.EmpName = _sqlDataReader["EmpName"] != DBNull.Value ? _sqlDataReader["EmpName"].ToString() : string.Empty;
                                getResponse.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
                                getResponse.Jobname = _sqlDataReader["Jobname"] != DBNull.Value ? _sqlDataReader["Jobname"].ToString() : string.Empty;
                                getResponse.JoinDate = _sqlDataReader["JoinDate"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["JoinDate"]));
                                getResponse.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                                getResponse.BankAcc = _sqlDataReader["BankAcc"] != DBNull.Value ? _sqlDataReader["BankAcc"].ToString() : string.Empty;
                                
                                response.ereadInformation.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<EReadInformationResponse> WReadInformation()
        {
            EReadInformationResponse response = new EReadInformationResponse();
            response.wreadInformation = new List<WReadInformation>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_ViewWork";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                WReadInformation getResponse = new WReadInformation();
                                getResponse.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                                getResponse.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
                                getResponse.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
                                getResponse.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                                getResponse.JoinDate = _sqlDataReader["JoinDate"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["JoinDate"]));
                                getResponse.Grade = _sqlDataReader["Grade"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Grade"]) : 0;
                                getResponse.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                                getResponse.BankAC = _sqlDataReader["BankAC"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["BankAC"]) : 0;
                                response.wreadInformation.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<EReadInformationResponse> ECReadInformation()
        {
            EReadInformationResponse response = new EReadInformationResponse();
            response.ecreadInformation = new List<ECReadInformation>();
            response.IsSuccess = true;
            response.Message = "Successful";
            
            try
            {
                string StoreProcedure = "usp_HMEmployee";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                ECReadInformation getResponse = new ECReadInformation();
                                getResponse.Count = _sqlDataReader["Count"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Count"]) : 0;
                                

                                response.ecreadInformation.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<EReadInformationResponse> WCReadInformation()
        {
            EReadInformationResponse response = new EReadInformationResponse();
            response.wcreadInformation = new List<WCReadInformation>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_HMWorkers";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                WCReadInformation getResponse = new WCReadInformation();
                                getResponse.Count = _sqlDataReader["Count"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Count"]) : 0;
                                response.wcreadInformation.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<EReadInformationResponse> SReadInformation()
        {
            EReadInformationResponse response = new EReadInformationResponse();
            response.sreadInformation = new List<SReadInformation>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_ViewSalary";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                SReadInformation getResponse = new SReadInformation();
                                getResponse.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                                getResponse.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
                                getResponse.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
                                getResponse.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                                getResponse.Update_date = _sqlDataReader["Updt"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["Updt"]));
                                getResponse.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                                getResponse.Salary_Amount = _sqlDataReader["SalaryAmt"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["SalaryAmt"]) : 0;
                                response.sreadInformation.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<EReadInformationResponse> JReadInformation()
        {
            EReadInformationResponse response = new EReadInformationResponse();
            response.jreadInformation = new List<JReadInformation>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_ViewJobs";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                JReadInformation getResponse = new JReadInformation();

                                getResponse.JobId = _sqlDataReader["JobId"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["JobId"]) : 0;
                                getResponse.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                                getResponse.SectionsId = _sqlDataReader["SectionsId"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["SectionsId"]) : 0;
                                getResponse.Grade = _sqlDataReader["Grade"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Grade"]) : 0;
                                getResponse.Food = _sqlDataReader["Food"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Food"]) : 0;
                                getResponse.Att_Bonus = _sqlDataReader["Att_Bonus"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Att_Bonus"]) : 0;
                                response.jreadInformation.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<EReadInformationResponse> JSReadInformation()
        {
            EReadInformationResponse response = new EReadInformationResponse();
            response.jsreadInformation = new List<JSReadInformation>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string count = "null";
            try
            {
                string StoreProcedure = "usp_ViewSec";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                JSReadInformation getResponse = new JSReadInformation();

                               
                                getResponse.SectionsName = _sqlDataReader["SectionsName"] != DBNull.Value ? _sqlDataReader["SectionsName"].ToString() : string.Empty;
                                getResponse.SectionsId = _sqlDataReader["SectionsId"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["SectionsId"]) : 0;

                                
                                response.jsreadInformation.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<EReadInformationResponse> JCReadInformation()
        {
            EReadInformationResponse response = new EReadInformationResponse();
            response.jcreadInformation = new List<JCReadInformation>();
            response.IsSuccess = true;
            response.Message = "Successful";
            
            try
            {
                string StoreProcedure = "usp_HMJobs";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                JCReadInformation getResponse = new JCReadInformation();

                                getResponse.Count = _sqlDataReader["Count"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Count"]) : 0;
                                
                                response.jcreadInformation.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<EReadInformationResponse> JSCReadInformation()
        {
            EReadInformationResponse response = new EReadInformationResponse();
            response.jscreadInformation = new List<JSCReadInformation>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_HMJobs";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                JSCReadInformation getResponse = new JSCReadInformation();


                                
                                getResponse.Count = _sqlDataReader["Count"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Count"]) : 0;


                                response.jscreadInformation.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<EReadInformationResponse> BReadInformation()
        {
            EReadInformationResponse response = new EReadInformationResponse();
            response.breadInformation = new List<BReadInformation>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_ViewBtyp";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                BReadInformation getResponse = new BReadInformation();


                                getResponse.Btype = _sqlDataReader["Btype"] != DBNull.Value ? _sqlDataReader["Btype"].ToString() : string.Empty;
                                getResponse.Bcode = _sqlDataReader["Bcode"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Bcode"]) : 0;


                                response.breadInformation.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<EReadInformationResponse> LVTReadInformation()
        {
            EReadInformationResponse response = new EReadInformationResponse();
            response.lvtreadInformation = new List<LVTReadInformation>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_ViewLevTyps";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                LVTReadInformation getResponse = new LVTReadInformation();

                                getResponse.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                                getResponse.Status = _sqlDataReader["Status"] != DBNull.Value ? _sqlDataReader["Status"].ToString() : string.Empty;
                                getResponse.Valid_days = _sqlDataReader["Valid_days"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Valid_days"]) : 0;


                                response.lvtreadInformation.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<EReadInformationResponse> WagReadInformation()
        {
            EReadInformationResponse response = new EReadInformationResponse();
            response.wagreadInformation = new List<WagReadInformation>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_ViewALLWage";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                WagReadInformation getResponse = new WagReadInformation();

                                getResponse.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                                getResponse.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
                                getResponse.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
                                getResponse.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                                getResponse.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                                getResponse.BankAcc = _sqlDataReader["BankAcc"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["BankAcc"]) : 0;
                                //getResponse.Salary = _sqlDataReader["Salary"] != DBNull.Value ? Convert.ToDecimal(_sqlDataReader["Salary"]) : 0m;
                                //getResponse.WorkDay = _sqlDataReader["WorkDay"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["WorkDay"]) : 0;
                                //getResponse.Other = _sqlDataReader["Other"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Other"]) : 0;
                                //getResponse.FestH = _sqlDataReader["FestH"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["FestH"]) : 0;
                                //getResponse.LeaveD = _sqlDataReader["LeaveD"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["LeaveD"]) : 0;
                                //getResponse.Leavetyp = _sqlDataReader["Leavetyp"] != DBNull.Value ? _sqlDataReader["LeaveTyp"].ToString() : string.Empty;
                                //getResponse.Absent = _sqlDataReader["Absent"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Absent"]) : 0;
                                //getResponse.TDays = _sqlDataReader["TDays"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["TDays"]) : 0;
                                //getResponse.Bonus = _sqlDataReader["Bonus"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Bonus"]) : 0;
                                //getResponse.Lwp = _sqlDataReader["Lwp"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Lwp"]) : 0;
                                //getResponse.Code = _sqlDataReader["Code"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Code"]) : 0;
                                //getResponse.GROSS = _sqlDataReader["GROSS"] != DBNull.Value ? Convert.ToDecimal(_sqlDataReader["GROSS"]) : 0m;
                                //getResponse.Deduct = _sqlDataReader["Deduct"] != DBNull.Value ? Convert.ToDecimal(_sqlDataReader["Deduct"]) : 0m;
                                //getResponse.NET = _sqlDataReader["NET"] != DBNull.Value ? Convert.ToDecimal(_sqlDataReader["NET"]) : 0m;
                                //getResponse.ACT_RE = _sqlDataReader["ACT_RE"] != DBNull.Value ? _sqlDataReader["ACT_RE"].ToString() : string.Empty;
                                //getResponse.Month = _sqlDataReader["Month"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["Month"]));


                                response.wagreadInformation.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        




        public async Task<UpdateInformationResponse> UpdateInformation(EUpdateInformationRequest request)
        {
            UpdateInformationResponse resposne = new UpdateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_EditEmp";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.UpdateInformation, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@EmpId", request.EmpId);
                        sqlCommand.Parameters.AddWithValue("@EmpName", request.EmpName);
                        sqlCommand.Parameters.AddWithValue("@SectionName", request.SectionName);
                        sqlCommand.Parameters.AddWithValue("@JobName", request.Jobname);
                        sqlCommand.Parameters.AddWithValue("@JoinDate", request.JoinDate);
                        sqlCommand.Parameters.AddWithValue("@CardNo", request.CardNo);
                        sqlCommand.Parameters.AddWithValue("@BankAcc", request.BankAcc);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "Information Not Update";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<UpdateInformationResponse> UpdateInformation(WUpdateInformationRequest request)
        {
            UpdateInformationResponse resposne = new UpdateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_EditWorker";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.UpdateInformation, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        sqlCommand.Parameters.AddWithValue("@Name", request.Name);
                        sqlCommand.Parameters.AddWithValue("@SectionName", request.SectionName);
                        sqlCommand.Parameters.AddWithValue("@JobName", request.JobName);
                        sqlCommand.Parameters.AddWithValue("@JoinDate", request.JoinDate);
                        sqlCommand.Parameters.AddWithValue("@CardNo", request.CardNo);
                        sqlCommand.Parameters.AddWithValue("@BankAC", request.BankAC);
                        sqlCommand.Parameters.AddWithValue("@Grade", request.Grade);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "Information Not Update";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {

                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<UpdateInformationResponse> UpdateInformation(SUpdateInformationRequest request)
        {
            UpdateInformationResponse resposne = new UpdateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_EditSalary";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.UpdateInformation, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        
                        sqlCommand.Parameters.AddWithValue("@Updt", request.Update_date);
                        
                        sqlCommand.Parameters.AddWithValue("@SalaryAmt", request.Salary_Amount);
                        
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "Information Not Update";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {

                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<UpdateInformationResponse> UpdateInformation(BSalUpdateInformationRequest request)
        {
            UpdateInformationResponse resposne = new UpdateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "InsertorUpdateBSLIP";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.UpdateInformation, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        sqlCommand.Parameters.AddWithValue("@SectionName", request.SectionName);
                        sqlCommand.Parameters.AddWithValue("@Name", request.Name);
                        sqlCommand.Parameters.AddWithValue("@JobName", request.JobName);
                        sqlCommand.Parameters.AddWithValue("@CardNo", request.CardNo);
                        sqlCommand.Parameters.AddWithValue("@BankAcc", request.BankAC);
                        sqlCommand.Parameters.AddWithValue("@Btype", request.BType);
                        sqlCommand.Parameters.AddWithValue("@Bonus", request.Bonus);
                        sqlCommand.Parameters.AddWithValue("@Gross", request.Gross);
                        sqlCommand.Parameters.AddWithValue("@Net", request.Net);
                        sqlCommand.Parameters.AddWithValue("@Deduct", request.Deduct);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "Information Not Update";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {

                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<UpdateInformationResponse> UpdateInformation(OTUpdateInformationRequest request)
        {
            UpdateInformationResponse resposne = new UpdateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "InsertorUpdateOTSLIP";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.UpdateInformation, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        sqlCommand.Parameters.AddWithValue("@SectionName", request.SectionName);
                        sqlCommand.Parameters.AddWithValue("@Name", request.Name);
                        sqlCommand.Parameters.AddWithValue("@JobName", request.JobName);
                        sqlCommand.Parameters.AddWithValue("@CardNo", request.CardNo);
                        sqlCommand.Parameters.AddWithValue("@BankAcc", request.BankAC);
                        sqlCommand.Parameters.AddWithValue("@Month", request.Month);
                        sqlCommand.Parameters.AddWithValue("@Hour", request.Hour);
                        sqlCommand.Parameters.AddWithValue("@ExHour", request.ExHour);
                        sqlCommand.Parameters.AddWithValue("@Gross", request.Gross);
                        sqlCommand.Parameters.AddWithValue("@Net_OT", request.Net_OT);
                        sqlCommand.Parameters.AddWithValue("@Deduct", request.Deduct);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "Information Not Update";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {

                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<UpdateInformationResponse> UpdateInformation(JUpdateInformationRequest request)
        {
            UpdateInformationResponse resposne = new UpdateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_EditJob";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.UpdateInformation, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("JobId", request.JobId);
                        sqlCommand.Parameters.AddWithValue("@SectionsId", request.SectionsId);
                        sqlCommand.Parameters.AddWithValue("@JobName", request.JobName);
                        sqlCommand.Parameters.AddWithValue("@Grade", request.Grade);
                        sqlCommand.Parameters.AddWithValue("@Att_Bonus", request.Att_Bonus);
                        sqlCommand.Parameters.AddWithValue("@Food", request.Food);
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "Information Not Update";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {

                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<UpdateInformationResponse> UpdateInformation(JSUpdateInformationRequest request)
        {
            UpdateInformationResponse resposne = new UpdateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_EditSec";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.UpdateInformation, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        
                        sqlCommand.Parameters.AddWithValue("@SectionsId", request.SectionsId);
                        sqlCommand.Parameters.AddWithValue("@SectionsName", request.SectionsName);
                        
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "Information Not Update";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {

                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<UpdateInformationResponse> UpdateInformation(LVTUpdateInformationRequest request)
        {
            UpdateInformationResponse resposne = new UpdateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_Editlevtyp";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.UpdateInformation, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        sqlCommand.Parameters.AddWithValue("@Status", request.Status);
                        sqlCommand.Parameters.AddWithValue("@Valid_days", request.Valid_days);

                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "Information Not Update";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {

                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<UpdateInformationResponse> UpdateInformation(EmpATTUpdateInformationRequest request)
        {
            UpdateInformationResponse resposne = new UpdateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_EditEmpATT";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.UpdateInformation, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@Id", request.EntryId);
                        sqlCommand.Parameters.AddWithValue("@EmpId", request.EmpId);
                        sqlCommand.Parameters.AddWithValue("@EmpName", request.EmpName);
                        sqlCommand.Parameters.AddWithValue("@SectionId", request.SectionId);
                        sqlCommand.Parameters.AddWithValue("@CardNo", request.CardNo);
                        sqlCommand.Parameters.AddWithValue("@Day", request.Day);
                        sqlCommand.Parameters.AddWithValue("@Status", request.Status);
                        

                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "Information Not Update";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {

                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<UpdateInformationResponse> UpdateInformation(WorkATTUpdateInformationRequest request)
        {
            UpdateInformationResponse resposne = new UpdateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_Editlevtyp";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.UpdateInformation, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        sqlCommand.Parameters.AddWithValue("@EntryId", request.EntryId);
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        sqlCommand.Parameters.AddWithValue("@Name", request.Name);
                        sqlCommand.Parameters.AddWithValue("@SectionName", request.SectionName);
                        sqlCommand.Parameters.AddWithValue("@JobName", request.JobName);
                        sqlCommand.Parameters.AddWithValue("@CardNo", request.CardNo);
                        sqlCommand.Parameters.AddWithValue("@Day", request.Day);
                        sqlCommand.Parameters.AddWithValue("@Status", request.Status);

                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "Information Not Update";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {

                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<UpdateInformationResponse> UpdateInformation(WagUpdateInformationRequest request)
        {
            UpdateInformationResponse resposne = new UpdateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "InsertOrUpdateSalaryData";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.UpdateInformation, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        sqlCommand.Parameters.AddWithValue("@WorkDay", request.Work_Day);
                        sqlCommand.Parameters.AddWithValue("@Other", request.Other);
                        sqlCommand.Parameters.AddWithValue("@SalaryAmt", request.SalaryAmt);
                        sqlCommand.Parameters.AddWithValue("@FestH", request.FestH);
                        sqlCommand.Parameters.AddWithValue("@We", request.We);
                        sqlCommand.Parameters.AddWithValue("@El", request.El);
                        sqlCommand.Parameters.AddWithValue("@Cl", request.Cl);
                        sqlCommand.Parameters.AddWithValue("@Sl", request.Sl);
                        sqlCommand.Parameters.AddWithValue("@Absent", request.Absent);
                        sqlCommand.Parameters.AddWithValue("@TDays", request.TDays);
                        sqlCommand.Parameters.AddWithValue("@Bonus", request.Bonus);
                        sqlCommand.Parameters.AddWithValue("@Gross", request.Gross);
                        sqlCommand.Parameters.AddWithValue("@Net", request.Net);
                        sqlCommand.Parameters.AddWithValue("@Lwp", request.Lwp);
                        sqlCommand.Parameters.AddWithValue("@Deduct", request.Deduct);
                        //sqlCommand.Parameters.AddWithValue("@ACT_RE", request.ACT_RE);
                        sqlCommand.Parameters.AddWithValue("@Month", request.Month);
                        


                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status == 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "Information Not Update";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {

                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<UpdateInformationResponse> UpdateInformation(WagSlipUpdateInformationRequest request)
        {
            UpdateInformationResponse resposne = new UpdateInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "InsertorUpdateWages";
                    //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.UpdateInformation, _mySqlConnection))
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;

                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        sqlCommand.Parameters.AddWithValue("@Name", request.Name);
                        sqlCommand.Parameters.AddWithValue("@SectionName", request.SectionName);
                        sqlCommand.Parameters.AddWithValue("@JobName", request.JobName);
                        sqlCommand.Parameters.AddWithValue("@BankAcc", request.BankAcc);
                        sqlCommand.Parameters.AddWithValue("@CardNo", request.CardNo);
                        sqlCommand.Parameters.AddWithValue("@OT_hours", request.OT_hours);
                        sqlCommand.Parameters.AddWithValue("@OT_Amount", request.OT_Amount);
                        sqlCommand.Parameters.AddWithValue("@Grade", request.Grade);
                        sqlCommand.Parameters.AddWithValue("@Basic", request.Basic);
                        sqlCommand.Parameters.AddWithValue("@Medical", request.Medical);
                        sqlCommand.Parameters.AddWithValue("@Conv", request.Conv);
                        sqlCommand.Parameters.AddWithValue("@Food", request.Food);
                        sqlCommand.Parameters.AddWithValue("@HR", request.HR);
                        sqlCommand.Parameters.AddWithValue("@Days", request.Days);
                        sqlCommand.Parameters.AddWithValue("@Att_Bonus", request.Att_Bonus);
                        sqlCommand.Parameters.AddWithValue("@Gross_Wages", request.Gross_Wages);
                        sqlCommand.Parameters.AddWithValue("@Net_Wages", request.Net_Wages);
                        sqlCommand.Parameters.AddWithValue("@Wages", request.Wages);
                        sqlCommand.Parameters.AddWithValue("@Deduct", request.Deduct);
                        sqlCommand.Parameters.AddWithValue("@Rate", request.Rate);
                        sqlCommand.Parameters.AddWithValue("@Net_Pay", request.Net_Pay);
                        sqlCommand.Parameters.AddWithValue("@Month", request.Month);



                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status == 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "Information Not Update";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {

                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }



        public async Task<DeleteInformationResponse> EDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse resposne = new DeleteInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "DeleteEmp";
                    
                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        //sqlCommand.Parameters.AddWithValue("?UserId", request.UserId);
                        sqlCommand.Parameters.AddWithValue("@EmpId", request.Id);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "UnSuccessful";
                        }
                       
                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<DeleteInformationResponse> WDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse resposne = new DeleteInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_deleteWorker";

                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        //sqlCommand.Parameters.AddWithValue("?UserId", request.UserId);
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "UnSuccessful";
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<DeleteInformationResponse> SDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse resposne = new DeleteInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_deleteSalary";

                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        //sqlCommand.Parameters.AddWithValue("?UserId", request.UserId);
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "UnSuccessful";
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<DeleteInformationResponse> JDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse resposne = new DeleteInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_deleteJobs";

                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        //sqlCommand.Parameters.AddWithValue("?UserId", request.UserId);
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "UnSuccessful";
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<DeleteInformationResponse> JSDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse resposne = new DeleteInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_deleteJobsections";

                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        //sqlCommand.Parameters.AddWithValue("?UserId", request.UserId);
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "UnSuccessful";
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<DeleteInformationResponse> LVTDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse resposne = new DeleteInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_deleteLv";

                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        //sqlCommand.Parameters.AddWithValue("?UserId", request.UserId);
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "UnSuccessful";
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<DeleteInformationResponse> EmpATTDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse resposne = new DeleteInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_deleteEATT";

                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        //sqlCommand.Parameters.AddWithValue("?UserId", request.UserId);
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "UnSuccessful";
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }
        public async Task<DeleteInformationResponse> WorkATTDeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse resposne = new DeleteInformationResponse();
            resposne.IsSuccess = true;
            resposne.Message = "Successful";
            try
            {
                if (_sqlConnection != null)
                {
                    string StoreProcedure = "usp_deleteWATT";

                    using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = ConnectionTimeOut;
                        //sqlCommand.Parameters.AddWithValue("?UserId", request.UserId);
                        sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                        //await _mySqlConnection.OpenAsync();
                        await _sqlConnection.OpenAsync();
                        int Status = await sqlCommand.ExecuteNonQueryAsync();
                        if (Status <= 0)
                        {
                            resposne.IsSuccess = false;
                            resposne.Message = "UnSuccessful";
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                resposne.IsSuccess = false;
                resposne.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return resposne;
        }


        public async Task<SearchInformationByIdResponse> ESearchInformationById(ESearchInformationByIdRequest request)
        {
            SearchInformationByIdResponse response = new SearchInformationByIdResponse();
            response.IsSuccess = true;
            response.Message = "Successful";
            try
            {
                string StoredProcedure = "usp_ViewEmpbySec";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.SearchInformationById, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoredProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@SecId", request.Id);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            await _sqlDataReader.ReadAsync();
                            response.esearchInformationById = new ESearchInformationById();
                            response.esearchInformationById.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
                            response.esearchInformationById.SectionName = _sqlDataReader["SectionsName"] != DBNull.Value ? _sqlDataReader["SectionsName"].ToString() : string.Empty;
                            response.esearchInformationById.Jobname = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                            //response.esearchInformationById.JoinDate = _sqlDataReader["JoinDate"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["JoinDate"]));
                            //response.esearchInformationById.EmpName = _sqlDataReader["EmpName"] != DBNull.Value ? _sqlDataReader["EmpName"].ToString() : string.Empty;
                            response.esearchInformationById.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                            response.esearchInformationById.BankAcc = _sqlDataReader["Bank"] != DBNull.Value ? _sqlDataReader["Bank"].ToString() : string.Empty;



                        }
                        else
                        {
                            response.Message = "No data Found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<SearchInformationByIdResponse> EmpATTSearchInformationById(ESearchInformationByIdRequest request)
        {
            SearchInformationByIdResponse response = new SearchInformationByIdResponse();
            response.IsSuccess = true;
            response.Message = "Successful";
            try
            {
                string StoredProcedure = "usp_ViewEmpAttbyId";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.SearchInformationById, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoredProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@EmpId", request.Id);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            await _sqlDataReader.ReadAsync();
                            response.empATTSearchInformationById = new EmpATTSearchInformationById();
                            response.empATTSearchInformationById.EntryId = _sqlDataReader["EntryId"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["EntryId"]) : 0;
                            response.empATTSearchInformationById.EmpName = _sqlDataReader["EmpName"] != DBNull.Value ? _sqlDataReader["EmpName"].ToString() : string.Empty;
                            response.empATTSearchInformationById.SectionId = _sqlDataReader["SectionId"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["SectionId"]) : 0;
                            response.empATTSearchInformationById.Day = _sqlDataReader["Day"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["Day"]));
                            response.empATTSearchInformationById.Status = _sqlDataReader["Status"] == DBNull.Value ? Convert.ToInt32(_sqlDataReader["Status"]) : 0;
                            response.empATTSearchInformationById.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                        }
                        else
                        {
                            response.Message = "No data Found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<SearchInformationByIdResponse> WorkATTSearchInformationById(ESearchInformationByIdRequest request)
        {
            SearchInformationByIdResponse response = new SearchInformationByIdResponse();
            response.IsSuccess = true;
            response.Message = "Successful";
            try
            {
                string StoredProcedure = "usp_ViewWorkAttbyId";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.SearchInformationById, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoredProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            await _sqlDataReader.ReadAsync();
                            response.workATTSearchInformationById = new WorkATTSearchInformationById();
                            response.workATTSearchInformationById.EntryId = _sqlDataReader["EntryId"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["EntryId"]) : 0;
                            response.workATTSearchInformationById.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
                            response.workATTSearchInformationById.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
                            response.workATTSearchInformationById.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                            response.workATTSearchInformationById.Day = _sqlDataReader["Day"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["Day"]));
                            response.workATTSearchInformationById.Status = _sqlDataReader["Status"] == DBNull.Value ? Convert.ToInt32(_sqlDataReader["Status"]) : 0;
                            response.workATTSearchInformationById.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;



                        }
                        else
                        {
                            response.Message = "No data Found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<SearchInformationByIdResponse> SSearchInformationById(ESearchInformationByIdRequest request)
        {
            SearchInformationByIdResponse response = new SearchInformationByIdResponse();
            response.IsSuccess = true;
            response.Message = "Successful";
            try
            {
                string StoredProcedure = "usp_ViewSalbyId";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.SearchInformationById, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoredProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@Id", request.Id);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            await _sqlDataReader.ReadAsync();
                            response.ssearchInformationById = new SSearchInformationById();
                            //response.ssearchInformationById.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                            response.ssearchInformationById.Updt = _sqlDataReader["Updt"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["Updt"]));
                            
                            response.ssearchInformationById.SalaryAmt = _sqlDataReader["SalaryAmt"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["SalaryAmt"]) : 0;




                        }
                        else
                        {
                            response.Message = "No data Found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }



        public async Task<SalarySearchByDateResponse> BSalReadInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = new SalarySearchByDateResponse();
            response.bsalreadInformationBySection = new List<BSalReadInformationBySection>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_ViewBSal";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    sqlCommand.Parameters.AddWithValue("@SectionId", request.Id);
                    sqlCommand.Parameters.AddWithValue("@Btype", request.Date);
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                BSalReadInformationBySection getResponse = new BSalReadInformationBySection();


                                getResponse.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
                                getResponse.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                                getResponse.BankAcc = _sqlDataReader["BankAcc"] != DBNull.Value ? _sqlDataReader["BankAcc"].ToString() : string.Empty;
                                getResponse.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                                getResponse.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
                                getResponse.Salary = _sqlDataReader["SalaryAmt"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["SalaryAmt"]) : 0;
                                getResponse.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                                getResponse.Gross = _sqlDataReader["Gross"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Gross"]) : 0;
                                getResponse.Bonus = _sqlDataReader["Bonus"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Bonus"]) : 0;
                                getResponse.Deduct = _sqlDataReader["Deduct"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Deduct"]) : 0;
                                getResponse.PayDate = _sqlDataReader["PayDate"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["PayDate"]));


                                response.bsalreadInformationBySection.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<SalarySearchByDateResponse> WSearchInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = new SalarySearchByDateResponse();
            response.wsearchInformationBySection = new List<WSearchInformationBySection>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_ViewEmpbySec";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@SecId", request.Id);
                    sqlCommand.Parameters.AddWithValue("@Month", request.Date);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                WSearchInformationBySection getResponse = new WSearchInformationBySection();
                                getResponse.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                                getResponse.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
                                //getResponse.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
                                getResponse.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                                //getResponse.JoinDate = _sqlDataReader["JoinDate"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["JoinDate"]));
                                getResponse.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                                getResponse.BankAC = _sqlDataReader["BankAC"] != DBNull.Value ? _sqlDataReader["BankAC"].ToString() : string.Empty;
                                getResponse.Salary = _sqlDataReader["SalaryAmt"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["SalaryAmt"]) : 0;
                                //getResponse.Grade = _sqlDataReader["Grade"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Grade"]) : 0;
                                
                                getResponse.El = _sqlDataReader["El"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["El"]) : 0;
                                getResponse.ACT_RE = _sqlDataReader["ACT_RE"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["ACT_RE"]) : 0;
                                getResponse.Sl = _sqlDataReader["Sl"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Sl"]) : 0;
                                getResponse.Cl = _sqlDataReader["Cl"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Cl"]) : 0;
                                getResponse.Work_Day = _sqlDataReader["WorkDay"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["WorkDay"]) : 0;
                                getResponse.FestH = _sqlDataReader["FestH"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["FestH"]) : 0;
                                getResponse.Other = _sqlDataReader["Other"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Other"]) : 0;
                                getResponse.Absent = _sqlDataReader["Absent"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Absent"]) : 0;
                                getResponse.TDays = _sqlDataReader["TDays"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["TDays"]) : 0;
                                getResponse.Bonus = _sqlDataReader["Bonus"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Bonus"]) : 0;
                                
                                getResponse.Deduct = _sqlDataReader["Deduct"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Deduct"]) : 0;
                                getResponse.Net = _sqlDataReader["Net"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Net"]) : 0;
                                getResponse.Gross = _sqlDataReader["Gross"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Gross"]) : 0;
                                getResponse.Lwp = _sqlDataReader["Lwp"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Lwp"]) : 0;
                                
                                ////ponse.wagSearchInformationByDate.Date_sqlDataReader["Month"] != DBNull.Value ? _sqlDataReader["Month"].ToString() : string.Empty;
                                getResponse.We = _sqlDataReader["We"] == DBNull.Value ? Convert.ToInt32(_sqlDataReader["We"]) : 0;
                                

                                response.wsearchInformationBySection.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<SalarySearchByDateResponse> WSlipSearchInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = new SalarySearchByDateResponse();
            response.wslipsearchInformationBySection = new List<WSlipSearchInformationBySection>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "printWageSlip";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@SecId", request.Id);
                    sqlCommand.Parameters.AddWithValue("@Month", request.Date);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                WSlipSearchInformationBySection getResponse = new WSlipSearchInformationBySection();
                                //getResponse.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                                getResponse.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
                                //getResponse.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
                                getResponse.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                                getResponse.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                                getResponse.BankAcc = _sqlDataReader["BankAcc"] != DBNull.Value ? _sqlDataReader["BankAcc"].ToString() : string.Empty;
                                getResponse.Wages = _sqlDataReader["Wages"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Wages"]) : 0;
                                getResponse.Grade = _sqlDataReader["Grade"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Grade"]) : 0;
                                getResponse.Basic = _sqlDataReader["Basic"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Basic"]) : 0;
                                getResponse.HR = _sqlDataReader["HR"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["HR"]) : 0;
                                getResponse.Medical = _sqlDataReader["Medical"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Medical"]) : 0;
                                getResponse.Conv = _sqlDataReader["Conv"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Conv"]) : 0;
                                getResponse.Days = _sqlDataReader["Days"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Days"]) : 0;
                                getResponse.Food = _sqlDataReader["Food"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Food"]) : 0;
                                getResponse.Att_Bonus = _sqlDataReader["Att_Bonus"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Att_Bonus"]) : 0;
                                getResponse.Gross_Wages = _sqlDataReader["Gross_Wages"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Gross_Wages"]) : 0;
                                getResponse.Net_Wages = _sqlDataReader["Net_Wages"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Net_Wages"]) : 0;
                                getResponse.OT_Hours = _sqlDataReader["OT_Hours"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["OT_Hours"]) : 0;
                                getResponse.OT_Amount = _sqlDataReader["OT_Amount"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["OT_Amount"]) : 0;
                                getResponse.Deduct = _sqlDataReader["Deduct"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Deduct"]) : 0;
                                getResponse.Net_Pay = _sqlDataReader["Net_Pay"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Net_Pay"]) : 0;
                                getResponse.Month = _sqlDataReader["Month"] != DBNull.Value ? _sqlDataReader["Month"].ToString() : string.Empty;
                                getResponse.Rate = _sqlDataReader["Rate"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Rate"]) : 0;

                                response.wslipsearchInformationBySection.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<SalarySearchByDateResponse> WSlipReadInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = new SalarySearchByDateResponse();
            response.wslipreadInformationBySection = new List<WSlipReadInformationBySection>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_ViewWagesSlip";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@SectionId", request.Id);
                    sqlCommand.Parameters.AddWithValue("@Month", request.Date);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                WSlipReadInformationBySection getResponse = new WSlipReadInformationBySection();
                                getResponse.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                                getResponse.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
                                getResponse.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
                                getResponse.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                                getResponse.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                                getResponse.BankAcc = _sqlDataReader["BankAcc"] != DBNull.Value ? _sqlDataReader["BankAcc"].ToString() : string.Empty;
                                getResponse.Wages = _sqlDataReader["Wages"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Wages"]) : 0;
                                getResponse.Grade = _sqlDataReader["Grade"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Grade"]) : 0;
                                getResponse.Basic = _sqlDataReader["Basic"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Basic"]) : 0;
                                getResponse.HR = _sqlDataReader["HR"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["HR"]) : 0;
                                getResponse.Medical = _sqlDataReader["Medical"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Medical"]) : 0;
                                getResponse.Conv = _sqlDataReader["Conv"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Conv"]) : 0;
                                getResponse.Days = _sqlDataReader["Days"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Days"]) : 0;
                                getResponse.Food = _sqlDataReader["Food"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Food"]) : 0;
                                getResponse.Att_Bonus = _sqlDataReader["Att_Bonus"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Att_Bonus"]) : 0;
                                getResponse.Gross_Wages = _sqlDataReader["Gross_Wages"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Gross_Wages"]) : 0;
                                getResponse.Net_Wages = _sqlDataReader["Net_Wages"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Net_Wages"]) : 0;
                                getResponse.OT_Hours = _sqlDataReader["OT_Hours"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["OT_Hours"]) : 0;
                                getResponse.OT_Amount = _sqlDataReader["OT_Amount"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["OT_Amount"]) : 0;
                                getResponse.Deduct = _sqlDataReader["Deduct"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Deduct"]) : 0;
                                getResponse.Net_Pay = _sqlDataReader["Net_Pay"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Net_Pay"]) : 0;
                                getResponse.Month = _sqlDataReader["Month"] != DBNull.Value ? _sqlDataReader["Month"].ToString() : string.Empty;
                                getResponse.Rate = _sqlDataReader["Rate"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Rate"]) : 0;



                                response.wslipreadInformationBySection.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<SalarySearchByDateResponse> BSalSearchInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = new SalarySearchByDateResponse();
            response.bsalsearchInformationBySection = new List<BSalSearchInformationBySection>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "printBSLIP";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@SecId", request.Id);
                    sqlCommand.Parameters.AddWithValue("@BType", request.Date);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                BSalSearchInformationBySection getResponse = new BSalSearchInformationBySection();
                                //getResponse.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                                getResponse.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
                                getResponse.BType = _sqlDataReader["BType"] != DBNull.Value ? _sqlDataReader["BType"].ToString() : string.Empty;
                                getResponse.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                                //getResponse.JoinDate = _sqlDataReader["JoinDate"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["JoinDate"]));
                                getResponse.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                                getResponse.BankAC = _sqlDataReader["BankAcc"] != DBNull.Value ? _sqlDataReader["BankAcc"].ToString() : string.Empty;
                                //getResponse.Salary = _sqlDataReader["SalaryAmt"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["SalaryAmt"]) : 0;
                                
                                //getResponse.TDays = _sqlDataReader["TDays"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["TDays"]) : 0;
                                getResponse.Bonus = _sqlDataReader["Bonus"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Bonus"]) : 0;

                                getResponse.Deduct = _sqlDataReader["Deduct"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Deduct"]) : 0;
                                getResponse.Net = _sqlDataReader["Net"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Net"]) : 0;
                                getResponse.Gross = _sqlDataReader["Gross"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Gross"]) : 0;
                                


                                response.bsalsearchInformationBySection.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<SalarySearchByDateResponse> OTSearchInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = new SalarySearchByDateResponse();
            response.otsearchInformationBySection = new List<OTSearchInformationBySection>();
            response.IsSuccess = true;
            response.Message = "Successful";
            //string nu = "null";
            try
            {
                string StoreProcedure = "printOTSLIP";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@SecId", request.Id);
                    sqlCommand.Parameters.AddWithValue("@Month", request.Date);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                OTSearchInformationBySection getResponse = new OTSearchInformationBySection();
                                //getResponse.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                                getResponse.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
                                getResponse.Month = _sqlDataReader["Month"] != DBNull.Value ? _sqlDataReader["Month"].ToString() : string.Empty;
                                getResponse.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                                //getResponse.JoinDate = _sqlDataReader["JoinDate"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["JoinDate"]));
                                getResponse.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                                getResponse.BankAC = _sqlDataReader["BankAcc"] != DBNull.Value ? _sqlDataReader["BankAcc"].ToString() : string.Empty;
                                //getResponse.Salary = _sqlDataReader["SalaryAmt"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["SalaryAmt"]) : 0;

                                //getResponse.TDays = _sqlDataReader["TDays"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["TDays"]) : 0;
                                getResponse.Hour = _sqlDataReader["Hour"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Hour"]) : 0;
                                //getResponse.ExHour = _sqlDataReader["ExHour"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["ExHour"]) : 0;

                                getResponse.Deduct = _sqlDataReader["Deduct"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Deduct"]) : 0;
                                getResponse.Net_OT = _sqlDataReader["Net_OT"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Net_OT"]) : 0;
                                getResponse.Gross = _sqlDataReader["Gross"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Gross"]) : 0;



                                response.otsearchInformationBySection.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<SalarySearchByDateResponse> OTReadInformationBySection(SalarySearchByDateRequest request)
        {
            SalarySearchByDateResponse response = new SalarySearchByDateResponse();
            response.otreadInformationBySection = new List<OTReadInformationBySection>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_ViewOT";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    //await _mySqlConnection.OpenAsync();
                    sqlCommand.Parameters.AddWithValue("@SectionId", request.Id);
                    sqlCommand.Parameters.AddWithValue("@Month", request.Date);
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                OTReadInformationBySection getResponse = new OTReadInformationBySection();


                                getResponse.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
                                getResponse.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                                getResponse.BankAcc = _sqlDataReader["BankAcc"] != DBNull.Value ? _sqlDataReader["BankAcc"].ToString() : string.Empty;
                                getResponse.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                                getResponse.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
                                getResponse.Salary = _sqlDataReader["SalaryAmt"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["SalaryAmt"]) : 0;
                                getResponse.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                                getResponse.Gross = _sqlDataReader["Gross"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Gross"]) : 0;
                                getResponse.Hour = _sqlDataReader["Hour"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Hour"]) : 0;
                                getResponse.ExHour = _sqlDataReader["ExHour"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["ExHour"]) : 0;
                                getResponse.Deduct = _sqlDataReader["Deduct"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Deduct"]) : 0;
                                getResponse.PayDate = _sqlDataReader["PayDate"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["PayDate"]));


                                response.otreadInformationBySection.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }




        public async Task<SearchInformationByDateResponse> ESearchInformationByDate(SearchInformationByDateRequest request)
        {
            SearchInformationByDateResponse response = new SearchInformationByDateResponse();
            response.IsSuccess = true;
            response.Message = "Successful";
            try
            {
                string StoredProcedure = "usp_ViewEmpbyJD";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.SearchInformationById, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoredProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@Day", request.Day);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            await _sqlDataReader.ReadAsync();
                            response.eSearchInformationByDate = new ESearchInformationByDate();
                            response.eSearchInformationByDate.EmpId = _sqlDataReader["EmpId"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["EmpId"]) : 0;
                            response.eSearchInformationByDate.EmpName = _sqlDataReader["EmpName"] != DBNull.Value ? _sqlDataReader["EmpName"].ToString() : string.Empty;
                            response.eSearchInformationByDate.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
                            response.eSearchInformationByDate.Jobname = _sqlDataReader["Jobname"] != DBNull.Value ? _sqlDataReader["Jobname"].ToString() : string.Empty;
                            response.eSearchInformationByDate.JoinDate = _sqlDataReader["JoinDate"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["JoinDate"]));
                            //response.eSearchInformationByDate.EmpName = _sqlDataReader["EmpName"] != DBNull.Value ? _sqlDataReader["EmpName"].ToString() : string.Empty;
                            response.eSearchInformationByDate.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                            response.eSearchInformationByDate.BankAcc = _sqlDataReader["BankAcc"] != DBNull.Value ? _sqlDataReader["BankAcc"].ToString() : string.Empty;



                        }
                        else
                        {
                            response.Message = "No data Found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<SearchInformationByDateResponse> EmpATTSearchInformationByDate(SearchInformationByDateRequest request)
        {
            SearchInformationByDateResponse response = new SearchInformationByDateResponse();
            response.IsSuccess = true;
            response.Message = "Successful";
            try
            {
                string StoredProcedure = "usp_ViewEmpAttbyDate";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.SearchInformationById, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoredProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@Day", request.Day);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            await _sqlDataReader.ReadAsync();
                            response.empATTSearchInformationByDate = new EmpATTSearchInformationByDate();
                            response.empATTSearchInformationByDate.EntryId = _sqlDataReader["EntryId"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["EntryId"]) : 0;
                            response.empATTSearchInformationByDate.EmpId = _sqlDataReader["EmpId"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["EmpId"]) : 0;
                            response.empATTSearchInformationByDate.EmpName = _sqlDataReader["EmpName"] != DBNull.Value ? _sqlDataReader["EmpName"].ToString() : string.Empty;
                            response.empATTSearchInformationByDate.SectionId = _sqlDataReader["SectionId"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["SectionId"]) : 0;
                            response.empATTSearchInformationByDate.Day = _sqlDataReader["Day"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["Day"]));
                            response.empATTSearchInformationByDate.Status = _sqlDataReader["Status"] == DBNull.Value ? Convert.ToInt32(_sqlDataReader["Status"]) : 0;
                            response.empATTSearchInformationByDate.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;
                        }
                        else
                        {
                            response.Message = "No data Found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        public async Task<SearchInformationByDateResponse> WorkATTSearchInformationByDate(SearchInformationByDateRequest request)
        {
            SearchInformationByDateResponse response = new SearchInformationByDateResponse();
            response.IsSuccess = true;
            response.Message = "Successful";
            try
            {
                string StoredProcedure = "usp_ViewWorkAttbyDate";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.SearchInformationById, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoredProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@Day", request.Day);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            await _sqlDataReader.ReadAsync();
                            response.workATTSearchInformationByDate = new WorkATTSearchInformationByDate();
                            response.workATTSearchInformationByDate.EntryId = _sqlDataReader["EntryId"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["EntryId"]) : 0;
                            response.workATTSearchInformationByDate.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                            response.workATTSearchInformationByDate.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
                            response.workATTSearchInformationByDate.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
                            response.workATTSearchInformationByDate.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                            response.workATTSearchInformationByDate.Day = _sqlDataReader["Day"] == DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(null)) : DateOnly.FromDateTime(Convert.ToDateTime(_sqlDataReader["Day"]));
                            response.workATTSearchInformationByDate.Status = _sqlDataReader["Status"] == DBNull.Value ? Convert.ToInt32(_sqlDataReader["Status"]) : 0;
                            response.workATTSearchInformationByDate.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;



                        }
                        else
                        {
                            response.Message = "No data Found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }
        //public async Task<SalarySearchByDateResponse> WagSearchInformationByDate(SalarySearchByDateRequest request)
        //{
        //    SalarySearchByDateResponse response = new SalarySearchByDateResponse();
        //    response.IsSuccess = true;
        //    response.Message = "Successful";
        //    try
        //    {
        //        string StoredProcedure = "usp_ViewWagebyDate";
        //        //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.SearchInformationById, _mySqlConnection))
        //        using (SqlCommand sqlCommand = new SqlCommand(StoredProcedure, _sqlConnection))
        //        {
        //            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //            sqlCommand.CommandTimeout = ConnectionTimeOut;
        //            sqlCommand.Parameters.AddWithValue("@Day", request.Date);
        //            sqlCommand.Parameters.AddWithValue("@Id", request.Id);
        //            //await _mySqlConnection.OpenAsync();
        //            await _sqlConnection.OpenAsync();
        //            //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
        //            using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
        //            {
        //                if (_sqlDataReader.HasRows)
        //                {
        //                    await _sqlDataReader.ReadAsync();
        //                    response.wagSearchInformationByDate = new WagSearchInformationByDate();
        //                    response.wagSearchInformationByDate.El = _sqlDataReader["El"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["El"]) : 0;
        //                    response.wagSearchInformationByDate.ACT_RE = _sqlDataReader["ACT_RE"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["ACT_RE"]) : 0;
        //                    response.wagSearchInformationByDate.Sl = _sqlDataReader["Sl"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Sl"]) : 0;
        //                    response.wagSearchInformationByDate.Cl = _sqlDataReader["Cl"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Cl"]) : 0;
        //                    response.wagSearchInformationByDate.Work_Day = _sqlDataReader["Work_Day"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Work_Day"]) : 0;
        //                    response.wagSearchInformationByDate.FestH = _sqlDataReader["FestH"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["FestH"]) : 0;
        //                    response.wagSearchInformationByDate.Other = _sqlDataReader["Other"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Other"]) : 0;
        //                    response.wagSearchInformationByDate.Absent = _sqlDataReader["Absent"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Absent"]) : 0;
        //                    response.wagSearchInformationByDate.TDays = _sqlDataReader["TDays"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["TDays"]) : 0;
        //                    response.wagSearchInformationByDate.Bonus = _sqlDataReader["Bonus"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Bonus"]) : 0;
        //                    response.wagSearchInformationByDate.SalaryAmt = _sqlDataReader["SalaryAmt"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["SalaryAmt"]) : 0;
        //                    response.wagSearchInformationByDate.Deduct = _sqlDataReader["Deduct"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Deduct"]) : 0;
        //                    response.wagSearchInformationByDate.Net = _sqlDataReader["Net"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Net"]) : 0;
        //                    response.wagSearchInformationByDate.Gross = _sqlDataReader["Gross"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Gross"]) : 0;
        //                    response.wagSearchInformationByDate.Lwp = _sqlDataReader["Lwp"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Lwp"]) : 0;
        //                    //response.wagSearchInformationByDate.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
        //                    response.wagSearchInformationByDate.Name = _sqlDataReader["Name"] != DBNull.Value ? _sqlDataReader["Name"].ToString() : string.Empty;
        //                    response.wagSearchInformationByDate.SectionName = _sqlDataReader["SectionName"] != DBNull.Value ? _sqlDataReader["SectionName"].ToString() : string.Empty;
        //                    response.wagSearchInformationByDate.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
        //                  ////ponse.wagSearchInformationByDate.Date_sqlDataReader["Month"] != DBNull.Value ? _sqlDataReader["Month"].ToString() : string.Empty;
        //                    response.wagSearchInformationByDate.We = _sqlDataReader["We"] == DBNull.Value ? Convert.ToInt32(_sqlDataReader["We"]) : 0;
        //                    response.wagSearchInformationByDate.CardNo = _sqlDataReader["CardNo"] != DBNull.Value ? _sqlDataReader["CardNo"].ToString() : string.Empty;



        //                }
        //                else
        //                {
        //                    response.Message = "No data Found";
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        response.IsSuccess = false;
        //        response.Message = "Exception Message : " + ex.Message;
        //    }
        //    finally
        //    {
        //        //await _mySqlConnection.CloseAsync();
        //        //await _mySqlConnection.DisposeAsync();
        //        await _sqlConnection.CloseAsync();
        //        await _sqlConnection.DisposeAsync();
        //    }

        //    return response;
        //}





        public async Task<SearchInformationByIdResponse> JSearchInformationBySection(ESearchInformationByIdRequest request)
        {
            SearchInformationByIdResponse response = new SearchInformationByIdResponse();
            response.jSearchInformationBySections = new List<JSearchInformationBySection>();
            response.IsSuccess = true;
            response.Message = "Successful";
            string nu = "null";
            try
            {
                string StoreProcedure = "usp_ViewJobsbySec";
                //using (MySqlCommand sqlCommand = new MySqlCommand(SqlQueries.ReadInformation, _mySqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand(StoreProcedure, _sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = ConnectionTimeOut;
                    sqlCommand.Parameters.AddWithValue("@SectionId", request.Id);
                    //await _mySqlConnection.OpenAsync();
                    await _sqlConnection.OpenAsync();
                    //using (DbDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    using (SqlDataReader _sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (_sqlDataReader.HasRows)
                        {
                            while (await _sqlDataReader.ReadAsync())
                            {
                                JSearchInformationBySection getResponse = new JSearchInformationBySection();
                                ///getResponse.Id = _sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Id"]) : 0;
                                getResponse.JobName = _sqlDataReader["JobName"] != DBNull.Value ? _sqlDataReader["JobName"].ToString() : string.Empty;
                                getResponse.JobId = _sqlDataReader["JobId"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["JobId"]) : 0;
                                getResponse.Grade = _sqlDataReader["Grade"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Grade"]) : 0;
                                getResponse.Food = _sqlDataReader["Food"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Food"]) : 0;
                                getResponse.Att_Bonus = _sqlDataReader["Att_Bonus"] != DBNull.Value ? Convert.ToInt32(_sqlDataReader["Att_Bonus"]) : 0;

                                response.jSearchInformationBySections.Add(getResponse);
                            }
                        }
                        else
                        {
                            response.Message = "No data Return";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            finally
            {
                //await _mySqlConnection.CloseAsync();
                //await _mySqlConnection.DisposeAsync();
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
            }

            return response;
        }


    }
}
