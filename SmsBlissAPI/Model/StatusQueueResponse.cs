using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public class StatusQueueResponse
	{
		/// <summary>
		/// Статус приема пакета (ok – ошибок не обнаружено)
		/// </summary>
		[DataMember(Name = "status")]
		public virtual ResponseStatus Status { get; set; }

		/// <summary>
		/// Описание
		/// </summary>
		[DataMember(Name = "description")]
		public virtual string Description { get; set; }

		/// <summary>
		/// Информация о статусах сообщений
		/// </summary>
		[DataMember(Name = "messages")]
		public virtual List<StatusQueueMessageInfo> MessageInfos { get; set; }
	}
}
