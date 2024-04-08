﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Vibro.API.Data
{
    public class VibroAuthDbContext : IdentityDbContext
    {
        public VibroAuthDbContext(DbContextOptions<VibroAuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Ensure the base method is called to configure the schema needed for the identity framework
            base.OnModelCreating(builder);

            // Predefined roles
            const string readerRoleId = "cdc56dee-3ebd-46da-8a12-a038efcb2618";
            const string writerRoleId = "44c9c25e-030f-4746-8edb-025d27b3e9bc";

            // Define roles
            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "READER"
                },
                new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "WRITER"
                },
            };

            // Seed roles
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}