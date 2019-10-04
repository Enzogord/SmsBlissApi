using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public enum MessageResponseStatus
	{
		[EnumMember(Value = "accepted")]
		[Display(Name = "Сообщение принято сервисом")]
		Accepted,

		[EnumMember(Value = "invalid mobile phone")]
		[Display(Name = "Неверно задан номер тефона (формат +71234567890)")]
		InvalidMobilePhone,

		[EnumMember(Value = "text is empty")]
		[Display(Name = "Отсутствует текст")]
		TextIsEmpty,

		[EnumMember(Value = "sender address invalid")]
		[Display(Name = "Неверная (незарегистрированная) подпись отправителя")]
		SenderAddressInvalid,

		[EnumMember(Value = "wapurl invalid")]
		[Display(Name = "Неправильный формат wap-push ссылки")]
		WapUrlInvalid,

		[EnumMember(Value = "invalid schedule time format")]
		[Display(Name = "Неверный формат даты отложенной отправки сообщения")]
		InvalidScheduleTimeFormat,

		[EnumMember(Value = "invalid status queue name")]
		[Display(Name = "Неверное название очереди статусов сообщений")]
		InvalidStatusQueueName,

		[EnumMember(Value = "not enough balance")]
		[Display(Name = "Баланс пуст (проверьте баланс)")]
		NotEnoughBalance
	}
}
