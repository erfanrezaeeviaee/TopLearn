using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Toplearn.DataLayer.Entities.User;

namespace Toplearn.DataLayer.Context
{
    public class ToplearnContext:DbContext
    {
        public ToplearnContext(DbContextOptions<ToplearnContext> options )
            :base(options)
        {

        }

        public ToplearnContext()
        {
            throw new NotImplementedException();
        }

        #region User
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        #endregion
    }
}
