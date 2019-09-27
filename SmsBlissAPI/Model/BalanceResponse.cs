using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public class BalanceResponse
	{
		/// <summary>
		/// Статус приема пакета (ok – ошибок не обнаружено)
		/// </summary>
		[DataMember(Name = "status")]
		public virtual ResponseStatus Status { get; set; }

		/// <summary>
		/// Остатки средств на балансе
		/// </summary>
		[DataMember(Name = "balance")]
		public virtual List<Balance> Balances { get; set; }
	}
}
