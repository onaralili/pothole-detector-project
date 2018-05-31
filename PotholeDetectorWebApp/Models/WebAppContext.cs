using System;
using Microsoft.EntityFrameworkCore;

namespace PotholeDetectorWebApp.Models
{
	public class WebAppContext : DbContext
	{
		public WebAppContext(DbContextOptions<WebAppContext> options) : base(options) { }
		public DbSet<Pothole> Potholes { get; set; }
	}
}
