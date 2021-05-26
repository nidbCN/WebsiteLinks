using System;
using System.ComponentModel.DataAnnotations;

namespace WebsiteLinks.Entities
{
    public class Website
    {
        public string Name { get; set; }

        [Url]
        public Uri Url { get; set; }

        public string Description { get; set; }

        [EmailAddress]
        public string Mail { get; set; }

        public bool Enabled { get; set; }
    }
}
