namespace librawry.portable.ef.entities {

	internal class TagRef {

		public int TitleId {
			get; set;
		}

		public Title Title {
			get; set;
		}

		public int TagId {
			get; set;
		}

		public Tag Tag {
			get; set;
		}
	}

}
