using System;
using System.Collections.Generic;

namespace Future.EFCore.Models
{
    public partial class Link
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string ShortUrl { get; set; }
        public string LongUrl { get; set; }
        public string UserId { get; set; }
    }
}
