using System;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public enum BalanceType
	{
		[DataMember(Name = "RUB")]
		RUB,
		[DataMember(Name = "SMS")]
		SMS
	}
}
