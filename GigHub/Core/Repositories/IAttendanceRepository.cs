using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Core.Repositories
{
    public interface IAttendanceRepository
    {
        bool GetAnyAttendance(int gigId, string userId);
        IEnumerable<Attendance> GetFutureAttendances(string userId);
    }
}