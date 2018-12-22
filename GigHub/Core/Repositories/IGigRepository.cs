using GigHub.Core.Models;
using System.Collections.Generic;

namespace GigHub.Core.Repositories
{
    public interface IGigRepository
    {
        Gig GetGig(int gigId);
        IEnumerable<Gig> GetUpcomingGigsByArtist(string artistId);
        Gig GetGigWithAttendees(int gigId);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        void Add(Gig gig);
        IEnumerable<Gig> GetUpcomingGigs(string searchTerm = null);
    }
}