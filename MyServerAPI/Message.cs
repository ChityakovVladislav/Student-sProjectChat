using System;

namespace Server
{
    public class Message
    {
        public string MessageText { get; set; }
        public DateTime SendingTime { get; set; }
        public Guid SenderId { get; set; }
        public Guid MessageId { get; set; }
    }
}