using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TelegramBotApi.Types.Enums;

namespace TelegramBotApi.Types
{
    /// <summary>
    /// This object represents a chat.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Chat
    {
        /// <summary>
        /// Unique identifier for this chat, not exceeding 1e13 by absolute value
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public long Id { get; set; }

        /// <summary>
        /// Type of chat
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public ChatType Type { get; set; }

        /// <summary>
        /// Optional. Title, for channels and group chats
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Optional. Username, for private chats and channels if available
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// Optional. First name of the other party in a private chat
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// Optional. Last name of the other party in a private chat
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// Optional. True if a group has 'All Members Are Admins' enabled.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool AllMembersAreAdministrators { get; set; }

        /// <summary>
        /// Optional. Description, for supergroups and channel chats. Returned only in getChat.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Optional. Chat invite link, for supergroups and channel chats. Returned only in getChat.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InviteLink { get; set; }
    }
}
