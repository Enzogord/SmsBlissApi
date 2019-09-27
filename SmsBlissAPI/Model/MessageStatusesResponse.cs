using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public class MessageStatusesResponse
	{
		/// <summary>
		/// Статус приема пакета (ok – ошибок не обнаружено)
		/// </summary>
		[DataMember(Name = "status")]
		public virtual ResponseStatus Status { get; set; }

		/// <summary>
		/// Информация о статусах сообщений
		/// </summary>
		[DataMember(Name = "messages")]
		public virtual List<MessageStatusInfo> MessageInfos { get; set; }
	}
}
