using GigHub.Core.Models;
using System.Collections.Generic;

namespace GigHub.Core.Repositories
{
    public interface IFollowingRepository
    {
        bool GetAnyFollowings(string userId, string artistId);
        List<ApplicationUser> GetFollowees(string userId);
    }
}