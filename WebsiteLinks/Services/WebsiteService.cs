using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebsiteLinks.Entities;

namespace WebsiteLinks.Services
{
    public class WebsiteService : IWebsiteService
    {
        Website IWebsiteService.AddWebsite(Website website)
        {

            throw new NotImplementedException();
        }

        Task<Website> IWebsiteService.GetWebsiteFromDb(Uri url)
        {
            throw new NotImplementedException();
        }

        Task<Website> IWebsiteService.GetWebsiteFromRequest(Uri url)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Website>> IWebsiteService.GetWebsiteList()
        {
            throw new NotImplementedException();
        }
    }
}
