﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public class MessageStatusInfo
	{
		/// <summary>
		/// Статус отправленного сообщения
		/// </summary>
		[DataMember(Name = "status")]
		public virtual MessageStatus Status { get; set; }

		/// <summary>
		/// Id сообщения на стороне сервера
		/// </summary>
		[DataMember(Name = "smscId")]
		public virtual string SmscId { get; set; }

		/// <summary>
		/// Id сообщения на стороне клиента (если было указано)
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
