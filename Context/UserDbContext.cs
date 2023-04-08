using Microsoft.EntityFrameworkCore;
using PracticalTest.Models;
using System.Collections.Generic;

namespace PracticalTest.Context
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> Context) : base(Context)

        {

        }
        //Create table in database
        public DbSet<User> Userss { get; set; }

    }
}
