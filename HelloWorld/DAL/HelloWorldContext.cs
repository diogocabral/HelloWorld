using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using HelloWorld.Models;

namespace HelloWorld.DAL
{
    public class HelloWorldContext : DbContext
    {
        public HelloWorldContext() : base("HelloWorldContext")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}