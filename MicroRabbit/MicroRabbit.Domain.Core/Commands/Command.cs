using MicroRabbit.Domain.Core.Events;
using System;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; } // protected set is for only who inherit from that class can set the value (abstract class!)

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
