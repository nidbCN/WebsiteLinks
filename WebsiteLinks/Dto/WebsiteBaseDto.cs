using System;
using System.ComponentModel.DataAnnotations;

namespace WebsiteLinks.Dto
{
    public class WebsiteBaseDto
    {
        public string Name { get; set; }

        [Url]
        public Uri Url { get; set; }

        public string Description { get; set; }
    }
}
