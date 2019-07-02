using api_rest_training.Models;
using System.Collections.Generic;

namespace api_rest_training.Services.Interfaces
{
    public interface IPersonServices
    {
        Person Create(Person person);
        Person FindViewById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
