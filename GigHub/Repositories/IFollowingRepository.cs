namespace GigHub.Repositories
{
    public interface IFollowingRepository
    {
        bool GetAnyFollowings(string userId, string artistId);
    }
}