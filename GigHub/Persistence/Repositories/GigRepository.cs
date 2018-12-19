using GigHub.Core.Models;
using GigHub.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GigHub.Persistence.Repositories
{
    public class GigRepository : IGigRepository
    {
        private readonly ApplicationDbContext _context;

        public GigRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Gig> GetGigsUserAttending(string userId)
        {
            return _context.Attendances
                .Where(a => a.AttendeeId == userId)
                .Select(a => a.Gig)
                .Include(g => g.Artist)
                .Include(g => g.Genre)
                .ToList();
        }

        public Gig GetGigWithAttendees(int gigId)
        {
            return _context.Gigs
                .Include(g => g.Attendances.Select(a => a.Attendee))
                .SingleOrDefault(g => g.Id == gigId);
        }

        public IEnumerable<Gig> GetUpcomingGigsArtist(string userId)
        {
            return _context.Gigs
                .Where(a => a.ArtistId == userId)
                .Include(g => g.Genre)
                .ToList();
        }

        public Gig GetGigDetails(int gigId)
        {
            return _context.Gigs
                .Include(g => g.Artist)
                .Include(g => g.Genre)
                .SingleOrDefault(g => g.Id == gigId);
        }

        public Gig GetGigToEdit(int gigId)
        {
            return _context.Gigs.Single(g => g.Id == gigId);
        }

        public IEnumerable<Gig> GetAllUpcomingGigs()
        {
            return _context.Gigs
                 .Include(g => g.Artist)
                 .Include(g => g.Genre)
                 .Where(g => g.DateTime > DateTime.Now && !g.IsCanceled);
        }

        public IEnumerable<Gig> GetAllUpcomingGigsQuery(string query, IEnumerable<Gig> upComingGigs)
        {

            return upComingGigs
                .Where(g =>
                    g.Artist.Name.Contains(query) ||
                    g.Genre.Name.Contains(query) ||
                    g.Venue.Contains(query));
        }
    }
}