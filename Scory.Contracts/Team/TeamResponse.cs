using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scory.Contracts.Team
{
    public record TeamResponse
    (
        Guid Id,
        string Name,
        string City,
        string Country,
        string Arena,
        string Description,
        string LogoUrl,
        string WebsiteUrl,
        List<string> Players
    );
}