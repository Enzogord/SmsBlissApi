using System;
using System.Runtime.Serialization;
namespace SmsBlissAPI.Model
{
	[DataContract]
	public sealed class Message
	{
		/// <summary>
		/// Номер телефона, в формате +71234567890
		/// </summary>
		[DataMember(Name = "phone")]
		public string Phone { get; set; }

		/// <summary>
		/// Подпись отправителя – это подпись адресата, которую абоненты видят на своем телефоне при получении SMS сообщения.
		/// Размер подписи ограничен 11 (одиннадцатью) символами.
		/// </summary>
		[DataMember(Name = "sender")]
		public string Sender { get; set; }

		/// <summary>
		/// Id сообщения на стороне клиента (A-Z 0-9, макс. 72 симв.)
		/// </summary>
		[DataMember(Name = "clientId")]
		public string ClientId { get; set; }

		/// <summary>
		/// Текст сообщения, в UTF-8 кодировке.
		/// <para> 
		/// Одно SMS-сообщение - это информация размером до 140 байт, вмещающих до 160 символов в латинице, 
		/// либо до 70 символов в кириллице, или каждая часть сочленённого сообщения размером до 133 байт, 
		/// вмещающая до 153 символов в латинице, либо до 67 символов в кириллице, или каждое бинарное 
		/// сообщение размером до 140 байт. Заключительные фрагменты сочленённых текстовых или бинарных 
		/// сообщений меньшего размера, считаются как отдельные сообщения. Например, в случае отправки 
		/// двух сочлененных сообщений, их длина ограничена 306 символами в латинице и 134 символами в 
		/// кириллице, при трех сочлененных сообщениях, соответственно, 459 и 201 символов.
		/// </para>
		/// </summary>
		[DataMember(Name = "text")]
		public string Text { get; set; }

		public Message(string clientId, string phone, string text, string sender = null)
		{
			ClientId = clientId;
			Phone = phone;
			Text = text;
			Sender = sender;
		}
	}
}
