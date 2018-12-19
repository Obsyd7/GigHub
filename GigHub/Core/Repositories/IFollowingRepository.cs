namespace GigHub.Core.Repositories
{
    public interface IFollowingRepository
    {
        bool GetAnyFollowings(string userId, string artistId);
    }
}