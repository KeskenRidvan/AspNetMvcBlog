﻿namespace App.Core.Models
{
	public class CategoryPost
	{
		public int PostId { get; set; }
		public Post Post { get; set; }

		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}
