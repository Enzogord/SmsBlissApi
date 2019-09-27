using System;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public enum ResponseStatus
	{
		[DataMember(Name = "ok")]
		Ok,
		[DataMember(Name = "error")]
		Error
	}
}
