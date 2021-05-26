using System.ComponentModel.DataAnnotations;

namespace WebsiteLinks.Dto
{
    public class WebsiteAddDto : WebsiteBaseDto
    {
        [EmailAddress]
        public string Mail { get; set; }
    }
}
