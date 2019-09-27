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
		[DataMember(Name = "active")]
		Active,

		/// <summary>
		/// Новая подпись
		/// </summary>
		[DataMember(Name = "new")]
		New,

		/// <summary>
		/// Подпись в процессе активации
		/// </summary>
		[DataMember(Name = "pending")]
		Pending,

		/// <summary>
		/// Подпись заблокирована
		/// </summary>
		[DataMember(Name = "blocked")]
		Blocked,

		/// <summary>
		/// Подпись по умолчанию, готова к использованию
		/// </summary>
		[DataMember(Name = "default")]
		Default
	}
}
