using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public sealed class MessageStatusesRequest
	{
		/// <summary>
		/// Логин
		/// </summary>
		[DataMember(Name = "login")]
		public string Login { get; set; }

		/// <summary>
		/// Пароль
		/// </summary>
		[DataMember(Name = "password")]
		public string Password { get; set; }

		/// <summary>
		/// Информация о сообщениях
		/// </summary>
		[DataMember(Name = "messages")]
		public List<MessageStatusRequestInfo> Messages { get; set; }

		public MessageStatusesRequest(string login, string password, IEnumerable<MessageStatusRequestInfo> messages)
		{
			Login = login;
			Password = password;
			Messages = new List<MessageStatusRequestInfo>(messages);

		}
	}
}
