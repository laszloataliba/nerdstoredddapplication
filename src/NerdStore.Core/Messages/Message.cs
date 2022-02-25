using System;

namespace NerdStore.Core.Messages
{
    public abstract class Message
    {
        public Message()
        {
            MessageType = GetType().Name;
        }

        public string MessageType { get; set; }
        public Guid AggregateId { get; set; }
    }
}
