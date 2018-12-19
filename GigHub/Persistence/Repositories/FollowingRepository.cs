using GigHub.Core.Models;
using GigHub.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace GigHub.Persistence.Repositories
{
    public class FollowingRepository : IFollowingRepository
    {
        private readonly ApplicationDbContext _context;

        public FollowingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool GetAnyFollowings(string userId, string artistId)
        {
            return _context.Followings
                .Any(f => f.FolloweeId == artistId && f.FollowerId == userId);
        }

        public List<ApplicationUser> GetFollowees(string userId)
        {
            return _context.Followings
                .Where(a => a.FollowerId == userId)
                .Select(c => c.Followee)
                .ToList();
        }
    }
}