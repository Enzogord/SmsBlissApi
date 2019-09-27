using System;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public sealed class MessageStatusRequestInfo
	{
		/// <summary>
		/// Id сообщения на стороне сервера
		/// </summary>
		[DataMember(Name = "smscId")]
		public string SmscId { get; set; }

		/// <summary>
		/// Id сообщения на стороне клиента
		/// </summary>
		[DataMember(Name = "clientId")]
		public string ClientId { get; set; }

		public MessageStatusRequestInfo(string smscId)
		{
			SmscId = smscId;
		}
	}
}
