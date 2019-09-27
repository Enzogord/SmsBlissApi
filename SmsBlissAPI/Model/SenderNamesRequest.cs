using System;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	/// <summary>
	/// Запрос списка доступных подписей отправителя
	/// </summary>
	[DataContract]
	public sealed class SenderNamesRequest
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

		public SenderNamesRequest(string login, string password)
		{
			Login = login;
			Password = password;
		}
	}
}
