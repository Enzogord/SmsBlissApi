using System;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public enum SenderNameStatus
	{
		/// <summary>
		/// Подпись активирована и готова к использованию
		/// </summary>
		[EnumMember(Value = "active")]
		Active,

		/// <summary>
		/// Новая подпись
		/// </summary>
		[EnumMember(Value = "new")]
		New,

		/// <summary>
		/// Подпись в процессе активации
		/// </summary>
		[EnumMember(Value = "pending")]
		Pending,

		/// <summary>
		/// Подпись заблокирована
		/// </summary>
		[EnumMember(Value = "blocked")]
		Blocked,

		/// <summary>
		/// Подпись по умолчанию, готова к использованию
		/// </summary>
		[EnumMember(Value = "default")]
		Default
	}
}
