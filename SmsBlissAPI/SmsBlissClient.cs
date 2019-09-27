using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using SmsBlissAPI.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace SmsBlissAPI
{
	public sealed class SmsBlissClient
	{
		private const string baseAddress = "http://api.smsbliss.net/messages/v2";
		private const string contentType = "application/json";

		private readonly string login;
		private readonly string password;

		public SmsBlissClient(string login, string password)
		{
			this.login = login;
			this.password = password;
		}

		public async Task<MessagesResponse> SendMessagesAsync(IEnumerable<Message> messages, string queueName = null, bool showBillingDetails = false)
		{
			if(messages == null) {
				throw new ArgumentNullException(nameof(messages));
			}

			MessagesRequest request = new MessagesRequest(login, password, messages);
			request.StatusQueueName = queueName;
			request.ShowBillingDetails = showBillingDetails;
			string content = JsonConvert.SerializeObject(request);

			using(HttpClient httpClient = new HttpClient()) {
				httpClient.DefaultRequestHeaders.Accept.Clear();
				httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
				HttpContent httpContent = new StringContent(content, Encoding.UTF8, contentType);
				string url = baseAddress + "/send.json";

				var httpResponse = await httpClient.PostAsync(url, httpContent);
				var responseContent = await httpResponse.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<MessagesResponse>(responseContent);
			}
		}

		public MessagesResponse SendMessages(IEnumerable<Message> messages, string queueName = null, bool showBillingDetails = false)
		{
			var sendMessageTask = SendMessagesAsync(messages, queueName, showBillingDetails);
			sendMessageTask.Wait();
			return sendMessageTask.Result;
		}

		public async Task<MessageStatusesResponse> GetMessageStatusesAsync(IEnumerable<MessageStatusRequestInfo> messages)
		{
			if(messages == null) {
				throw new ArgumentNullException(nameof(messages));
			}
			if(!messages.Any()) {
				throw new ArgumentException("Должны быть указаны сообщения для которых необходимо получить статусы");
			}

			MessageStatusesRequest request = new MessageStatusesRequest(login, password, messages);
			string content = JsonConvert.SerializeObject(request);

			using(HttpClient httpClient = new HttpClient()) {
				httpClient.DefaultRequestHeaders.Accept.Clear();
				httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
				HttpContent httpContent = new StringContent(content, Encoding.UTF8, contentType);
				string url = baseAddress + "/status.json";

				var httpResponse = await httpClient.PostAsync(url, httpContent);
				var responseContent = await httpResponse.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<MessageStatusesResponse>(responseContent);
			}
		}

		public MessageStatusesResponse GetMessageStatuses(IEnumerable<MessageStatusRequestInfo> messages)
		{
			var messageStatusesTask = GetMessageStatusesAsync(messages);
			messageStatusesTask.Wait();
			return messageStatusesTask.Result;
		}

		public async Task<StatusQueueResponse> GetQueueStatusAsync(string statusQueueName, int statusQueueLimit = 1)
		{
			if(statusQueueLimit <= 0) {
				throw new ArgumentException("Количество запрашиваемых статусов в очереди должно быть больше 1");
			}
			if(statusQueueLimit > 1000) {
				throw new ArgumentException("Максимальное количество запрашиваемых сообщений ограничено 1000 сообщений");
			}

			StatusQueueRequest request = new StatusQueueRequest(login, password, statusQueueLimit.ToString(), statusQueueName);
			string content = JsonConvert.SerializeObject(request);

			using(HttpClient httpClient = new HttpClient()) {
				httpClient.DefaultRequestHeaders.Accept.Clear();
				httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
				HttpContent httpContent = new StringContent(content, Encoding.UTF8, contentType);
				string url = baseAddress + "/statusQueue.json";

				var httpResponse = await httpClient.PostAsync(url, httpContent);
				var responseContent = await httpResponse.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<StatusQueueResponse>(responseContent);
			}
		}

		public StatusQueueResponse GetQueueStatus(string statusQueueName, int statusQueueLimit = 1)
		{
			var queueStatusTask = GetQueueStatusAsync(statusQueueName, statusQueueLimit);
			queueStatusTask.Wait();
			return queueStatusTask.Result;
		}

		public async Task<BalanceResponse> GetBalanceAsync()
		{
			BalanceRequest request = new BalanceRequest(login, password);
			string content = JsonConvert.SerializeObject(request);

			using(HttpClient httpClient = new HttpClient()) {
				httpClient.DefaultRequestHeaders.Accept.Clear();
				httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
				HttpContent httpContent = new StringContent(content, Encoding.UTF8, contentType);
				string url = baseAddress + "/balance.json";

				var httpResponse = await httpClient.PostAsync(url, httpContent);
				var responseContent = await httpResponse.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<BalanceResponse>(responseContent);
			}
		}

		public BalanceResponse GetBalance()
		{
			var balanceTask = GetBalanceAsync();
			balanceTask.Wait();
			return balanceTask.Result;
		}

		public async Task<SenderNamesResponse> GetSenderNamesAsync()
		{
			SenderNamesRequest request = new SenderNamesRequest(login, password);
			string content = JsonConvert.SerializeObject(request);

			using(HttpClient httpClient = new HttpClient()) {
				httpClient.DefaultRequestHeaders.Accept.Clear();
				httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
				HttpContent httpContent = new StringContent(content, Encoding.UTF8, contentType);
				string url = baseAddress + "/senders.json";

				var httpResponse = await httpClient.PostAsync(url, httpContent);
				var responseContent = await httpResponse.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<SenderNamesResponse>(responseContent);
			}
		}

		public SenderNamesResponse GetSenderNames()
		{
			var senderNamesTask = GetSenderNamesAsync();
			senderNamesTask.Wait();
			return senderNamesTask.Result;
		}

		public async Task<ApiVersionResponse> GetApiVersionAsync()
		{
			ApiVersionRequest request = new ApiVersionRequest(login, password);
			string content = JsonConvert.SerializeObject(request);

			using(HttpClient httpClient = new HttpClient()) {
				httpClient.DefaultRequestHeaders.Accept.Clear();
				httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
				HttpContent httpContent = new StringContent(content, Encoding.UTF8, contentType);
				string url = baseAddress + "/version.json";

				var httpResponse = await httpClient.PostAsync(url, httpContent);
				var responseContent = await httpResponse.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<ApiVersionResponse>(responseContent);
			}
		}

		public ApiVersionResponse GetApiVersion()
		{
			var apiVersionTask = GetApiVersionAsync();
			apiVersionTask.Wait();
			return apiVersionTask.Result;
		}
	}
}
