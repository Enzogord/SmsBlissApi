using System;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public enum BalanceType
	{
		[EnumMember(Value = "RUB")]
		RUB,
		[EnumMember(Value = "SMS")]
		SMS
	}
}
