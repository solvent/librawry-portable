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

		public virtual async Task<IEnumerable<ListResponse>> GetList(ListRequest param) {
			var query = context.Titles.AsQueryable();

			if (param.Search != null) {
				var search = string.Join("%", param.Search.Split(' '));

				query = query.Where(x =>
					EF.Functions.Like(x.Name, $"%{search}%") ||
					x.Episodes.Any(y => EF.Functions.Like(y.Name, $"%{search}%"))
				);
			}

			query = query.OrderBy(x => x.Name);

			if (param.Skip != null) {
				query = query.Skip(param.Skip.Value);
			}

			if (param.Take != null) {
				query = query.Take(param.Take.Value);
			}

			return await query
				.Select(x => new ListResponse(
					x.Id,
					x.Name,
					x.TagRefs.Select(y => new Tag(y.Tag.Id, y.Tag.Name))
				))
				.ToListAsync();
		}

		public virtual async Task<DetailsResponse?> GetDetails(int id) {
			return await context.Titles
				.Where(x => x.Id == id)
				.Select(x => new DetailsResponse(
					x.Id,
					x.Name,
					x.Episodes.Select(y => new Episode(y.Id, y.Name)),
					x.TagRefs.Select(y => new Tag(y.Tag.Id, y.Tag.Name))
				))
				.AsSplitQuery()
				.FirstOrDefaultAsync();
		}
	}

}
