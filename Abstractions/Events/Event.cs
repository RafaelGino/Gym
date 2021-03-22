using MediatR;
using System;

namespace Domain.Abstractions.Events
{
    public class Event : INotification
    {
        public Guid OperationId { get; private set; }

        public Event()
        {
            this.OperationId = Guid.NewGuid();
        }
    }
}
