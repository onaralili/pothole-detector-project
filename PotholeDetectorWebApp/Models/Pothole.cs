using System;
namespace PotholeDetectorWebApp.Models
{
    public class Pothole
    {
		public int id { get; set; }
		public string lat { get; set; }
		public string lon { get; set; }
		public DateTime date { get; set; }
		public string time { get; set; }
		public int NumberOfPotholes { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }
    }
}
