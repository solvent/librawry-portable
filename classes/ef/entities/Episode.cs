namespace librawry.portable.ef.entities {

	internal class Episode {

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
			get; set;
		}
	}

}
