using System;

namespace librawry.portable.ef.entities;

internal class TagRef {
	private Tag? _tag;
	private Title? _title;

	public int TitleId {
		get; set;
	}

	public Title Title {
		get => _title ?? throw new InvalidOperationException();
		set => _title = value;
	}

	public int TagId {
		get; set;
	}

	public Tag Tag {
		get => _tag ?? throw new InvalidOperationException();
		set => _tag = value;
	}
}
