using System.Text.Json.Serialization;

namespace librawry.portable.repo.common;

public class Title {

	[JsonPropertyName("id")]
	public int Id {
		get; set;
	}

	[JsonPropertyName("name")]
	public string Name {
		get; set;
	}

	public Title(int id, string name) {
		Id = id;
		Name = name;
	}
}
