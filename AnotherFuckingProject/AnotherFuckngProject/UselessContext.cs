using AnotherFuckngProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AnotherFuckngProject
{
    public class UselessContext : DbContext
    {
        public UselessContext() : base("AnotherFuckngProject")
        {

        }


        public System.Data.Entity.DbSet<AnotherFuckngProject.Models.User> Users { get; set; }
        public System.Data.Entity.DbSet<AnotherFuckngProject.Models.Task> Tasks { get; set; }
    }
}