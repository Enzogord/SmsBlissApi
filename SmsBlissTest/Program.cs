using System;
using Newtonsoft.Json.Linq;
using System.Globalization;
using SmsBlissAPI;
using System.Collections.Generic;
using SmsBlissAPI.Model;
using Newtonsoft.Json;

namespace SmsBlissTest
{
	static class MainClass
	{
		private const string login = "";
		private const string password = "";

		private static SmsBlissClient smsBlissClient;

		public static void Main(string[] args)
		{
			smsBlissClient = new SmsBlissClient(login, password);

			

			Console.ReadKey();
		}

		private static void SendSMS()
		{
			//Отправка сообщений
			List<Message> messages = new List<Message> {
				new Message("1", "+71111111111", "Hello, world!"),
				new Message("2", "+72222222222", "Hello, world!"),
				new Message("3", "+73333333333", "Hello, world!"),
			};
			var response = smsBlissClient.SendMessages(messages, "testSmsQueue");
		}

		private static void GetMessageStatuses()
		{
			// Получение статусов сообщений
			List<MessageStatusRequestInfo> messages = new List<MessageStatusRequestInfo> {
				new MessageStatusRequestInfo("9999999999"),
				new MessageStatusRequestInfo("8888888888")
			};
			var response = smsBlissClient.GetMessageStatuses(messages);
		}

		private static void GetQueueStatus()
		{
			//Проверка статуса очереди
			var response = smsBlissClient.GetQueueStatus("testSmsQueue", 50);
		}

		private static void GetBalance()
		{
			//Получение баланса
			var response = smsBlissClient.GetBalance();
		}

		private static void GetSenderNames()
		{
			//Получение подписей
			var response = smsBlissClient.GetSenderNames(); ;
		}

		private static void GetApiVersion()
		{
			//Получение вермии api
			var response = smsBlissClient.GetApiVersion();
		}
	}
}
