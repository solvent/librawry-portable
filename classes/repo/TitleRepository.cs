using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using librawry.portable.ef;
using librawry.portable.repo.common;
using librawry.portable.repo.titles;
using Microsoft.EntityFrameworkCore;

namespace librawry.portable.repo {

	public class TitleRepository : Repository, ITitleRepository {

		public TitleRepository(LibrawryContext context) : base(context) {
		}

		public virtual async Task<IEnumerable<ListResponse>> GetList(string searchText) {
			var search = string.Join("%", searchText.Split(' '));

			return await context.Titles
				.Where(x =>
					EF.Functions.Like(x.Name, $"%{search}%") ||
					x.Episodes.Any(y => EF.Functions.Like(y.Name, $"%{search}%"))
				)
				.OrderBy(x => x.Name)
				.Select(x => new ListResponse {
					Id = x.Id,
					Name = x.Name,
					Tags = x.TagRefs
						.Select(y => y.Tag)
						.Select(y => new Tag {
							Id = y.Id,
							Name = y.Name
						}),
				})
				.ToListAsync();
		}

		public virtual async Task<DetailsResponse> GetDetails(int id) {
			return await context.Titles
				.Where(x => x.Id == id)
				.Select(x => new DetailsResponse {
					Id = x.Id,
					Name = x.Name,
					Tags = x.TagRefs
						.Select(y => y.Tag)
						.Select(y => new Tag {
							Id = y.Id,
							Name = y.Name
						}),
					Episodes = x.Episodes
						.Select(y => new Episode {
							Id = y.Id,
							Name = y.Name
						})
				})
				.AsSplitQuery()
				.FirstOrDefaultAsync();
		}
	}

}
