using System;

namespace librawry.portable.ef.entities {

	internal class Episode {
		private Title? _title;

		public int Id {
			get; set;
		}

		public string Name {
			get; set;
		}

		public int TitleId {
			get; set;
		}

		public Title Title {
			get => _title ?? throw new InvalidOperationException();
			set => _title = value;
		}

		public Episode(string name) {
			Name = name;
		}
	}

}
