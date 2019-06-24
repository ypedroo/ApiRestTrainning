using Accord.Statistics.Kernels;
using api_rest_training.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rest_training.Services.Interfaces
{
    interface IPersonServices
    {
        Person Create(Person person);
        Person FindViewById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
