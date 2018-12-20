using GigHub.Core.Models;
using System.Collections.Generic;

namespace GigHub.Core.Repositories
{
    public interface IFollowingRepository
    {
        List<ApplicationUser> GetFollowees(string userId);
        Following GetFollowing(string userId, string gigArtistId);
        void Add(Following following);
        void Remove(Following following);
    }
}