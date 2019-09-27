using System;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	/// <summary>
	/// Запрос баланса
	/// </summary>
	[DataContract]
	public sealed class BalanceRequest
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
		public string Password{ get; set; }

		public BalanceRequest(string login, string password)
		{
			Login = login;
			Password = password;
		}
	}
}
