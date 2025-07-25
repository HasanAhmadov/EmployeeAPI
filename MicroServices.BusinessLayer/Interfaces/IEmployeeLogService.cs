﻿using MicroServices.BusinessLayer.DTOs;

namespace MicroServices.BusinessLayer.Interfaces
{
    public interface IEmployeeLogService
    {
        Task<string> LogEntryAsync(Guid employeeId, EmployeeLogRequestDTO request);
        Task<IEnumerable<object>> GetAllLogsAsync();
        Task<IEnumerable<object>> GetLogsByEmployeeIdAsync(Guid employeeId);
        Task<List<AttendanceDTO>> GetAttendanceByEmployeeIdAsync(Guid employeeId, EmployeeDTO employee);
        Task<List<List<AttendanceDTO>>> GetAttendancesByRolesAsync(List<int> roleIds);
    }
}