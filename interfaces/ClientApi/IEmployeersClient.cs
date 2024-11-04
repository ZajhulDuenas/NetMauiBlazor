﻿using Models;
using Models.ClientApi;
using Models.DTOs;

namespace Front.Infrastructure.ClientApi
{
    public interface IEmployeersClient
    {
        string baseEndPoint { get; set; }
        ClientToken? ClientToken { get; set; }

        Task<Response<EmployeeRequestDto>> DeleteEmployee(int id);
        Task<Response<List<EmployeeRequestDto>>> GetEmployeersByIndex(int index = 1, int pageSize = 10);
        Task<Response<EmployeeRequestDto>> ModifyEmployee(EmployeeRequestDto request);
        Task<Response<ClientToken>> OnGetToken();
    }
}