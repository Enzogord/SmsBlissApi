using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public enum MessageStatus
	{
		[DataMember(Name = "queued")]
		[Display(Name = "Сообщение находится в очереди")]
		Queued,

		[DataMember(Name = "delivered")]
		[Display(Name = "Сообщение доставлено")]
		Delivered,

		[DataMember(Name = "delivery error")]
		[Display(Name = "Ошибка доставки SMS(абонент в течение времени доставки находился вне зоны действия сети или номер абонента заблокирован)")]
		DeliveryError,

		[DataMember(Name = "smsc submit")]
		[Display(Name = "Сообщение доставлено в SMSC")]
		SmscSubmit,

		[DataMember(Name = "smsc reject")]
		[Display(Name = "Сообщение отвергнуто SMSC(номер заблокирован или не существует)")]
		SmscReject,

		[DataMember(Name = "incorrect id")]
		[Display(Name = "Неверный идентификатор сообщения")]
		IncorrectId
	}
}
