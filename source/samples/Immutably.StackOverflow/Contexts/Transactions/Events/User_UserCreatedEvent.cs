using System;
using Immutably.Messages;

namespace Immutably.StackOverflow.Contexts.Transactions.Events
{
    public class User_UserCreatedEvent : IEvent
    {
        public Guid UserId { get; set; }
        public String About { get; set; }
    }
}