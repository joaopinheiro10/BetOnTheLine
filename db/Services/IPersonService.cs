using System.Collections.Generic;
using db.Model;


namespace db.Services
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAll(); 
    }
}