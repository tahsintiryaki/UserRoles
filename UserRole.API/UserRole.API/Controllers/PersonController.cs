using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserRoles.Contract.Models.Person;

namespace UserRole.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private static readonly string[] Names = new[]
         {
            "Mozart", "Linus", "Bill", "Chaplin", "Martin", "Bob", "Tesla", "Planck", "Einstein", "Ada"
        };

        public PersonController()
        {

        }
        [HttpGet]
        public IEnumerable<PersonModel> GetCustomer()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new PersonModel
            {
                Date = DateTime.Now.AddDays(index).ToShortDateString(),
                Age = rng.Next(18, 56),
                Score = rng.Next(1, 101),
                Name = Names[rng.Next(0, 10)]
            })
            .ToArray();
        }
        [HttpGet("GetCustomerById/{personID}")]
        public PersonModel GetCustomerById(string personID)
        {
            var rng = new Random();
            return new PersonModel
            {
                Date = DateTime.Now.ToShortDateString(),
                Age = rng.Next(18, 56),
                Score = rng.Next(1, 101),
                Name = Names.Any(n => n == personID) == false ? "Bora" : personID
            };
        }
        [HttpGet("GetCustomerList/{count}")]
        public IEnumerable<PersonModel> GetCustomerList(int count)
        {
            var rng = new Random();
            return Enumerable.Range(1, count).Select(index => new PersonModel
            {
                Date = DateTime.Now.AddDays(index).ToShortDateString(),
                Age = rng.Next(18, 56),
                Score = rng.Next(1, 101),
                Name = Names[rng.Next(0, 10)]
            })
            .ToArray();
        }

    }
}
