﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public DateTime ReleaseDate { get; set; }

        public User(string name, string password, int age, DateTime releaseDate)
        {
            Name = name;
            Password = password;
            Age = age;
            ReleaseDate = releaseDate;
        }
    }
}
