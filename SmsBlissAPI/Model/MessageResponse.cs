using System;
using System.Runtime.Serialization;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public class MessageResponse
	{
		/// <summary>
		/// Статус отправки сообщения
		/// </summary>
		[DataMember(Name = "status")]
		public virtual MessageResponseStatus Status { get; set; }

		/// <summary>
		/// Id сообщения на стороне сервера (A-F 0-9, макс. 72 симв.)
		/// </summary>
		[DataMember(Name = "smscId")]
		public virtual string SmscId { get; set; }

		/// <summary>
		/// Id сообщения на стороне клиента
		/// </summary>
		[DataMember(Name = "clientId")]
		public virtual string ClientId { get; set; }

		public virtual string GetStatusDescription()
		{
			DisplayAttribute displayAttribute = Status.GetType().GetCustomAttribute<DisplayAttribute>();
			if(displayAttribute == null) {
				return "Неизвестный статус";
			}
			return displayAttribute.Name;
		}
	}
}
