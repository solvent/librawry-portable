using System.Text.Json.Serialization;

namespace librawry.portable.repo.common {

	public class Tag {

		[JsonPropertyName("id")]
		public int Id {
			get; set;
		}

		[JsonPropertyName("name")]
		public string Name {
			get; set;
		}
	}
}
