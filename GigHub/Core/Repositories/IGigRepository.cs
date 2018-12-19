using GigHub.Core.Models;
using System.Collections.Generic;

namespace GigHub.Core.Repositories
{
    public interface IGigRepository
    {
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        Gig GetGigWithAttendees(int gigId);
        IEnumerable<Gig> GetUpcomingGigsArtist(string userId);
        Gig GetGigDetails(int gigId);
        Gig GetGigToEdit(int gigId);
        IEnumerable<Gig> GetAllUpcomingGigs();
        IEnumerable<Gig> GetAllUpcomingGigsQuery(string query, IEnumerable<Gig> upComingGigs);
    }
}