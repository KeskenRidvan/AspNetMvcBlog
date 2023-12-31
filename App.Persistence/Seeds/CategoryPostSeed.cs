﻿using App.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistence.Seeds
{
	public class CategoryPostSeed : IEntityTypeConfiguration<CategoryPost>
	{
		public void Configure(EntityTypeBuilder<CategoryPost> builder)
		{
			builder.HasData(
			new CategoryPost { PostId = 1, CategoryId = 1 },
			new CategoryPost { PostId = 2, CategoryId = 2 },
			new CategoryPost { PostId = 3, CategoryId = 3 });
		}
	}
}
