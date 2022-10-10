using System;
using System.Collections.Generic;

namespace librawry.portable.ef.entities {

	internal class Tag {
		private List<TagRef>? _tagRefs;

		public int Id {
			get; set;
		}

		public string Name {
			get; set;
		}

		public List<TagRef> TagRefs {
			get => _tagRefs ?? throw new InvalidOperationException();
			set => _tagRefs = value;
		}

		public Tag(string name) {
			Name = name;
		}
	}

}
