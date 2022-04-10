using System;
using System.Threading.Tasks;
using librawry.portable.ef;

namespace librawry.portable.repo {

	public class UnitOfWork : IUnitOfWork {
		private readonly LibrawryContext context;

		public UnitOfWork(LibrawryContext context) {
			this.context = context;
			TitleRepository = new TitleRepository(context);
		}

		public ITitleRepository TitleRepository { get; private set; }

		public async Task CompleteAsync() {
			await context.SaveChangesAsync();
		}

		#region IDisposable implementation
		private bool disposed;

		protected virtual void Dispose(bool disposing) {
			if (disposed) {
				return;
			}

			if (disposing) {
				context?.Dispose();
			}

			disposed = true;
		}

		void IDisposable.Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		#endregion
	}

}
