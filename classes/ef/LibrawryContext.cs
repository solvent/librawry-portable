using Microsoft.EntityFrameworkCore;
using librawry.portable.ef.entities;

namespace librawry.portable.ef {

	public class LibrawryContext : DbContext {

		internal DbSet<Title> Titles {
			get; set;
		}

		internal DbSet<Episode> Episodes {
			get; set;
		}

		internal DbSet<Tag> Tags {
			get; set;
		}

		internal DbSet<TagRef> TagRefs {
			get; set;
		}

		public LibrawryContext(DbContextOptions<LibrawryContext> options) : base(options) {
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Entity<TagRef>()
				.HasKey(t => new { t.TitleId, t.TagId });

			modelBuilder.Entity<TagRef>()
				.HasOne(tr => tr.Title)
				.WithMany(t => t.TagRefs)
				.HasForeignKey(tr => tr.TitleId);

			modelBuilder.Entity<TagRef>()
				.HasOne(tr => tr.Tag)
				.WithMany(t => t.TagRefs)
				.HasForeignKey(tr => tr.TagId);
		}
	}

}
