using System.Collections.Generic;
using System.Threading.Tasks;
using librawry.portable.repo.titles;

namespace librawry.portable;

public interface ITitleRepository {
	Task<IEnumerable<ListResponse>> GetList(ListRequest param);
	Task<DetailsResponse?> GetDetails(int id);
}
