using System;
using Microsoft.EntityFrameworkCore;
using Pustok1.Entities;

namespace Pustok1.DAL
{
	public class Pustok1DbContext : DbContext
	{
		public Pustok1DbContext(DbContextOptions<Pustok1DbContext> options):base(options){}

		public DbSet<Slider> Sliders{ get; set; }
		public DbSet<Feature> Features{ get; set; }

    }
}

