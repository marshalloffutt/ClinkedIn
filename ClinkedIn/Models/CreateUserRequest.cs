﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Models
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
