﻿using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        /*
        
        But now if we go back to application DB context, we have that right here, but we have to pass that connection string to the DB context as well because we will be using the basic features of the DB context most of the time. And if you notice in program.CS, we are getting that as application DB context and parameters here. So right here we can add a constructor where we expect the DB context options. Recall that as options and we just pass that on to the base class, which is DB context. These are the basic steps that are needed to configure entity framework core in any net application,

        */

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Villa> Villas { get; set; }
    }
}
