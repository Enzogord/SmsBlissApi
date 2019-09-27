using System;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public sealed class ApiVersionRequest
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

		public ApiVersionRequest(string login, string password)
		{
			Login = login;
			Password = password;
		}
	}
}
