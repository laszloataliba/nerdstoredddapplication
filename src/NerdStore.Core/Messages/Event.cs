using MediatR;
using System;

namespace NerdStore.Core.Messages
{
    public class Event : Message, INotification
    {
        public Event()
        {
            TimeStamp = DateTime.Now;
        }

        public DateTime TimeStamp { get; private set; }
    }
}
