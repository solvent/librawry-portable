using System.Collections.Generic;
using System.Text.Json.Serialization;
using librawry.portable.repo.common;

namespace librawry.portable.repo.titles {

	public class ListResponse {

		[JsonPropertyName("id")]
		public int Id {
			get; set;
		}

		[JsonPropertyName("name")]
		public string Name {
			get; set;
		}

		[JsonPropertyName("tags")]
		public IEnumerable<Tag> Tags {
			get; set;
		}
	}
}
