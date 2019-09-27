using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Linq;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public sealed class MessagesRequest
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
		/// Включение в ответ биллинговых данных: баланса, количества SMS в сообщении, стоимость сообщения
		/// </summary>
		[DataMember(Name = "showBillingDetails")]
		public bool ShowBillingDetails { get; set; }

		/// <summary>
		/// Название очереди статусов отправленных сообщений. От 3 до 16 символов, буквы и цифры (например myQueue1)
		/// </summary>
		[DataMember(Name = "statusQueueName")]
		public string StatusQueueName { get; set; }

		/// <summary>
		/// Дата для отложенной отправки сообщения, в UTC (2008-07-12T14:30:01Z)
		/// </summary>
		private string scheduleTimeUTC;

		[DataMember(Name = "scheduleTime")]
		public string ScheduleTimeUTC {
			get => scheduleTimeUTC;
			set {
				scheduleTimeUTC = value;
				scheduleTime = DateTime.Parse(scheduleTimeUTC, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.AdjustToUniversal);
			}
		}

		private DateTime scheduleTime;
		/// <summary>
		/// Дата для отложенной отправки сообщения
		/// </summary>
		public DateTime ScheduleTime {
			get => scheduleTime;
			set {
				scheduleTime = value;
				scheduleTimeUTC = scheduleTime.ToUniversalTime().ToString("yyyy-MM-ddThh:mm:ssZ");

			}
		}

		/// <summary>
		/// Cообщения
		/// </summary>
		[DataMember(Name = "messages")]
		public List<Message> Messages { get; set; }

		/// <summary>
		/// Создание запроса на отправку сообщений (не более 200 сообщений в запросе)
		/// </summary>
		public MessagesRequest(string login, string password, IEnumerable<Message> messages)
		{
			if(messages.Count() > 200) {
				throw new NotSupportedException("Поддерживается масимум 200 сообщений в запросе");
			}
			Login = login;
			Password = password;
			Messages = new List<Message>(messages);
		}
	}
}
