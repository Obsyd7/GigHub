using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Core.Repositories
{
    public interface IGenreRepository
    {
        void Add(Gig gig);
        List<Genre> GetAllGenres();
    }
}