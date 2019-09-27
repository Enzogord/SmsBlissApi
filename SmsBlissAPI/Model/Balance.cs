using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public class Balance
	{
		/// <summary>
		/// Кредит (возможность использовать сервис при отрицательном балансе)
		/// </summary>
		[DataMember(Name = "credit")]
		public virtual string Credit { get; set; }

		/// <summary>
		/// Количество средств на балансе
		/// </summary>
		[DataMember(Name = "balance")]
		public virtual string BalanceValue { get; set; }

		/// <summary>
		/// Тип баланса: RUB, SMS
		/// </summary>
		[DataMember(Name = "type")]
		[JsonConverter(typeof(StringEnumConverter))]
		public virtual BalanceType Type { get; set; }
	}
}
