using System.Collections.Generic;
using System.Text.Json.Serialization;
using librawry.portable.repo.common;

namespace librawry.portable.repo.titles {

	public class DetailsResponse {

		[JsonPropertyName("id")]
		public int Id {
			get; set;
		}

		[JsonPropertyName("name")]
		public string Name {
			get; set;
		}

		[JsonPropertyName("episodes")]
		public IEnumerable<Episode> Episodes {
			get; set;
		}

		[JsonPropertyName("tags")]
		public IEnumerable<Tag> Tags {
			get; set;
		}

		public DetailsResponse(int id, string name, IEnumerable<Episode> episodes, IEnumerable<Tag> tags) {
			Id = id;
			Name = name;
			Episodes = episodes;
			Tags = tags;
		}
	}
}
