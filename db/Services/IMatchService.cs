using System.Collections.Generic;
using db.Model;

namespace db.Services
{
    public interface IMatchService
    {
        IEnumerable<Match> GetAll(); 
    }
}