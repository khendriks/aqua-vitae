using AquaVitae.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AquaVitae.DataAccessLayer
{
    public class AquaVitaeContext : DbContext
    {
        public AquaVitaeContext() : base("AquaVitaeConnectionString")
        {
        }

        /// <summary>
        /// Gets or sets the reunisten.
        /// </summary>
        /// <value>
        /// The reunisten.
        /// </value>
        public DbSet<Reunist> Reunisten { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();            
        }

    }
}