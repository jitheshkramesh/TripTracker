using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Repository
    {
        private List<Trip> MyTrips = new List<Trip>
        {
            new Trip
            {
                Id = 1,
                Name = "MVP Submit",
                StartDate = new DateTime(2019, 3, 4),
                EndDate = new DateTime(2019, 05, 15)

            },
            new Trip
            {
                Id = 2,
                Name = "MVP Submit 2",
                StartDate = new DateTime(2019, 3, 5),
                EndDate = new DateTime(2019, 05, 17)
            },
            new Trip
            {
                Id = 3,
                Name = "MVP Submit 3",
                StartDate = new DateTime(2019, 3, 6),
                EndDate = new DateTime(2019, 05, 18)
            },
            new Trip
            {
                Id = 4,
                Name = "MVP Submit 4",
                StartDate = new DateTime(2019, 3, 7),
                EndDate = new DateTime(2019, 05, 25)
            },

            new Trip
            {
                Id = 5,
                Name = "MVP Submit 5",
                StartDate = new DateTime(2019, 3, 8),
                EndDate = new DateTime(2019, 05, 19)
            }
        };

        public List<Trip> Get()
        {
            return MyTrips;
        }

        public Trip Get(int id)
        {
            return MyTrips.FirstOrDefault(t => t.Id == id);
        }
        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);
        }

        public void Update(Trip tripToUpdate)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == tripToUpdate.Id));
            Add(tripToUpdate);
        }

        public void Remove(int id)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == id));
        }
    }
}