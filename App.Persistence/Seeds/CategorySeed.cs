using App.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistence.Seeds
{
	public class CategorySeed : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasData(
			new Category { Id = 1, Name = "Technology" },
			new Category { Id = 2, Name = "Nature" },
			new Category { Id = 3, Name = "Science" },
			new Category { Id = 4, Name = "Sport" }
			);
		}
	}
}
