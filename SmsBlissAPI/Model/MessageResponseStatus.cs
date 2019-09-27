using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public enum MessageResponseStatus
	{
		[DataMember(Name = "accepted")]
		[Display(Name = "Сообщение принято сервисом")]
		Accepted,

		[DataMember(Name = "invalid mobile phone")]
		[Display(Name = "Неверно задан номер тефона (формат +71234567890)")]
		InvalidMobilePhone,

		[DataMember(Name = "text is empty")]
		[Display(Name = "Отсутствует текст")]
		TextIsEmpty,

		[DataMember(Name = "sender address invalid")]
		[Display(Name = "Неверная (незарегистрированная) подпись отправителя")]
		SenderAddressInvalid,

		[DataMember(Name = "wapurl invalid")]
		[Display(Name = "Неправильный формат wap-push ссылки")]
		WapUrlInvalid,

		[DataMember(Name = "invalid schedule time format")]
		[Display(Name = "Неверный формат даты отложенной отправки сообщения")]
		InvalidScheduleTimeFormat,

		[DataMember(Name = "invalid status queue name")]
		[Display(Name = "Неверное название очереди статусов сообщений")]
		InvalidStatusQueueName,

		[DataMember(Name = "not enough balance")]
		[Display(Name = "Баланс пуст (проверьте баланс)")]
		NotEnoughBalance
	}
}
