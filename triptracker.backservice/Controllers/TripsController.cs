using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripTracker.BackService.Models;

namespace TripTracker.BackService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        private Repository _repository;
        public TripsController(Repository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Trip> Get()
        {
            return _repository.Get();
        }

        [HttpGet("{Id}")]
        public Trip Get(int id)
        {
            return _repository.Get(id);
        }

        [HttpPost]
        public void Post([FromBody]Trip value)
        {
            _repository.Add(value);
        }

        [HttpPut]
        public void Put(int id, [FromBody] Trip value)
        {
            _repository.Update(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Remove(id);
        }
    }
}