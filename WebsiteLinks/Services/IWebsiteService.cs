using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebsiteLinks.Entities;

namespace WebsiteLinks.Services
{
    public interface IWebsiteService
    {
        Task<IEnumerable<Website>> GetWebsiteList();

        Task<Website> GetWebsiteFromDb(Uri url);

        Task<Website> GetWebsiteFromRequest(Uri url);

        Website AddWebsite(Website website);
    }
}
