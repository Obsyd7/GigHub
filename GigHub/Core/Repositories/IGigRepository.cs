using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Core.Repositories
{
    public interface IGigRepository
    {
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        Gig GetGigWithAttendees(int gigId);
        IEnumerable<Gig> GetUpcomingGigsArtist(string userId);
        Gig GetGigDetails(int gigId);
        Gig GetGigToEdit(int gigId);
    }
}