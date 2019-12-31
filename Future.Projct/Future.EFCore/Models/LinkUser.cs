using System;
using System.Collections.Generic;

namespace Future.EFCore.Models
{
    public partial class LinkUser
    {
        public string UserId { get; set; }
        public string PassWord { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string AppId { get; set; }
    }
}
