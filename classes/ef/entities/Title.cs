using System;
using System.Collections.Generic;

namespace librawry.portable.ef.entities {

	internal class Title {
		private List<TagRef>? _tagRefs;
		private List<Episode>? _episodes;

		public int Id {
			get; set;
		}

		public string Name {
			get; set;
		}

		public List<Episode> Episodes {
			get => _episodes ?? throw new InvalidOperationException();
			set => _episodes = value;
		}

		public List<TagRef> TagRefs {
			get => _tagRefs ?? throw new InvalidOperationException();
			set => _tagRefs = value;
		}

		public Title(string name) {
			Name = name;
		}
	}

}
