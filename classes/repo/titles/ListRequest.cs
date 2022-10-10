using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace librawry.portable.repo.titles {

	public class ListRequest {
		[JsonPropertyName("search")]
		[MinLength(3)]
		public string? Search {
			get; set;
		}

		[JsonPropertyName("skip")]
		[Range(0, int.MaxValue)]
		public int? Skip {
			get; set;
		}

		[JsonPropertyName("take")]
		[Range(1, int.MaxValue)]
		public int? Take {
			get; set;
		}
	}

}
