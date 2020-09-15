using System.Collections.Generic;
using db.Model;

namespace db.Services
{
    public interface ITipService
    {
         IEnumerable<Tip> GetAll(); 
    }
}