using System;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public enum ResponseStatus
	{
		[EnumMember(Value = "ok")]
		Ok,
		[EnumMember(Value = "error")]
		Error
	}
}
