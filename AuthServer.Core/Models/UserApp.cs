﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Models
{
    public class UserApp : IdentityUser //Microsoft.AspNetCore.Identity.EntityFrameworkCore Paketi
    {
        public string City { get; set; }
    }
}
