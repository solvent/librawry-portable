using librawry.portable.ef;

namespace librawry.portable.repo {

	public class Repository {
		protected readonly LibrawryContext context;

		public Repository(LibrawryContext context) {
			this.context = context;
		}
	}

}
