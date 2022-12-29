using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scory.Models
{
    public class Team
    {
        public Guid Id { get; }
        public string Name { get;  }
        public string City { get;  }
        public string Country { get;  }
        public string Arena { get; }
        public string Description { get;  }
        public string LogoUrl { get; }
        public string WebsiteUrl { get;  }
        public List<string> Players { get; }

        public Team(
            Guid id,
            string name,
            string city,
            string country,
            string arena,
            string description,
            string logoUrl,
            string websiteUrl,
            List<string> players)
        {
            Id = id;
            Name = name;
            City = city;
            Country = country;
            Arena = arena;
            Description = description;
            LogoUrl = logoUrl;
            WebsiteUrl = websiteUrl;
            Players = players;
        }
    }
}