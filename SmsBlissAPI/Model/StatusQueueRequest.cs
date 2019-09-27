using System;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public sealed class StatusQueueRequest
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
		/// Количество запрашиваемых статусов из очереди (по умолчанию 1, макс. 1000)
		/// </summary>
		[DataMember(Name = "statusQueueLimit")]
		public string StatusQueueLimit { get; set; }

		/// <summary>
		/// Название очереди статусов сообщений. Название очереди устанавливается при передаче сообщения
		/// </summary>
		[DataMember(Name = "statusQueueName")]
		public string StatusQueueName { get; set; }

		public StatusQueueRequest(string login, string password, string statusQueueLimit, string statusQueueName)
		{
			Login = login;
			Password = password;
			StatusQueueLimit = statusQueueLimit;
			StatusQueueName = statusQueueName;
		}
	}
}
