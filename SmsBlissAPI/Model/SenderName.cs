using System;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	/// <summary>
	/// Подпись отправителя
	/// </summary>
	[DataContract]
	public class SenderName
	{
		/// <summary>
		/// Статус подписи отправителя
		/// </summary>
		[DataMember(Name = "status")]
		public virtual SenderNameStatus Status { get; set; }

		/// <summary>
		/// Информация о пидписе отправителя
		/// </summary>
		[DataMember(Name = "info")]
		public virtual string Info { get; set; }

		/// <summary>
		/// Подпись отправителя
		/// </summary>
		[DataMember(Name = "name")]
		public virtual string Name { get; set; }
	}
}
