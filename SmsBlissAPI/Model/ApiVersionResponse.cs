using System;
using System.Runtime.Serialization;

namespace SmsBlissAPI.Model
{
	[DataContract]
	public class ApiVersionResponse
	{
		[DataMember(Name = "status")]
		public virtual ResponseStatus Status { get; set; }

		/// <summary>
		/// Номер активной версии API
		/// </summary>
		[DataMember(Name = "version")]
		public virtual int Version { get; set; }
	}
}
