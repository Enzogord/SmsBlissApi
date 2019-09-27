using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public class SenderNamesResponse
	{
		/// <summary>
		/// Статус приема пакета (ok – ошибок не обнаружено)
		/// </summary>
		[DataMember(Name = "status")]
		public virtual ResponseStatus Status { get; set; }

		/// <summary>
		/// Список доступных подписей
		/// </summary>
		[DataMember(Name = "senders")]
		public virtual List<SenderName> SenderNames { get; set; }
	}
}
