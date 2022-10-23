using System;
using System.Threading.Tasks;

namespace librawry.portable;

public interface IUnitOfWork : IDisposable {
	ITitleRepository TitleRepository { get; }
	Task CompleteAsync();
}
