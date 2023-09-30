using librawry.portable.ef;
using Microsoft.EntityFrameworkCore;

namespace librawry.portable.repo;

public class UnitOfWorkFactory : IUnitOfWorkFactory {
	private readonly IDbContextFactory<LibrawryContext> dbContextFactory;

	public UnitOfWorkFactory(IDbContextFactory<LibrawryContext> dbContextFactory) {
		this.dbContextFactory = dbContextFactory;
	}

	public IUnitOfWork Create() {
		return new UnitOfWork(dbContextFactory.CreateDbContext());
	}
}
