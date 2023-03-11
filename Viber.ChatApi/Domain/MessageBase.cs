﻿using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Base message info.
	/// </summary>
	public abstract class MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MessageBase"/> class.
		/// </summary>
		/// <param name="type">Message type.</param>
		protected MessageBase(MessageType type)
		{
			Type = type;
		}

		/// <summary>
		/// Unique Viber user id.
		/// </summary>
		[JsonPropertyName("receiver")]
		public string Receiver { get; set; } = default!;

        /// <summary>
        /// Message type.
        /// </summary>
        [JsonPropertyName("type")]
		public MessageType Type { get; }

		/// <summary>
		/// Sender of the message.
		/// </summary>
		[JsonPropertyName("sender")]
		public UserBase Sender { get; set; } = default!;

        /// <summary>
        /// Allow the account to track messages and user’s replies. Sent tracking_data value will be passed back with user’s reply.
        /// </summary>
        [JsonPropertyName("tracking_data")]
		public string TrackingData { get; set; } = default!;

		/// <summary>
		/// Minimal API version required by clients for this message (default 1).
		/// </summary>
		[JsonPropertyName("min_api_version")]
		public double? MinApiVersion { get; set; } = 6;
	}
}