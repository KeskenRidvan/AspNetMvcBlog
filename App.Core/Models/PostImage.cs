﻿using App.Core.Persistence;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
	public class PostImage : IEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[DisplayName("Resim URL")]
		public string ImageUrl { get; set; }


		public int PostId { get; set; }
		public Post Post { get; set; }
	}
}
