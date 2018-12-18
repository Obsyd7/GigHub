using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.Repositories
{
    public interface IGenreRepository
    {
        void Add(Gig gig);
        List<Genre> GetAllGenres();
    }
}