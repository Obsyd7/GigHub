using GigHub.Models;
using System.Linq;

namespace GigHub.Repositories
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
    }
}