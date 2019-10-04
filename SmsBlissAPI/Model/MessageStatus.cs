using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public enum MessageStatus
	{
		[EnumMember(Value = "queued")]
		[Display(Name = "Сообщение находится в очереди")]
		Queued,

		[EnumMember(Value = "delivered")]
		[Display(Name = "Сообщение доставлено")]
		Delivered,

		[EnumMember(Value = "delivery error")]
		[Display(Name = "Ошибка доставки SMS(абонент в течение времени доставки находился вне зоны действия сети или номер абонента заблокирован)")]
		DeliveryError,

		[EnumMember(Value = "smsc submit")]
		[Display(Name = "Сообщение доставлено в SMSC")]
		SmscSubmit,

		[EnumMember(Value = "smsc reject")]
		[Display(Name = "Сообщение отвергнуто SMSC(номер заблокирован или не существует)")]
		SmscReject,

		[EnumMember(Value = "incorrect id")]
		[Display(Name = "Неверный идентификатор сообщения")]
		IncorrectId
	}
}
