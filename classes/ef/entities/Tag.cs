using System.Collections.Generic;

namespace librawry.portable.ef.entities {

	internal class Tag {

		public int Id {
			get; set;
		}

		public string Name {
			get; set;
		}

		public List<TagRef> TagRefs {
			get; set;
		}
	}

}
