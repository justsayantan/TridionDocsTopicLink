using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TridionDocsTopicLink.Models
{
    public class Publication
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ModifiedOn { get; set; }
        public string Status { get; set; }
        public string PublicationType { get; set; }
    }
}