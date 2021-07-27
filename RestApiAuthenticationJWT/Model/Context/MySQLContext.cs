﻿using Microsoft.EntityFrameworkCore;

namespace RestApiAuthenticationJwt.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {
        
        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<User> Users { get; set; } 
    }
}