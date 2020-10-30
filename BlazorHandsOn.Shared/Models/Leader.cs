using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorHandsOn.Shared.Models
{
	public class Leader
	{
		public string Name { get; set; }
		public string Image { get; set; }
		public string Designation { get; set; }
		public string Abbr { get; set; }
		public string Description { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
