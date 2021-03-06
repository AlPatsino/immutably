using System;
using Immutably.Messages;

namespace Immutably.StackOverflow.Contexts.Transactions.Events
{
    public class Comment_ContentChangedEvent : IEvent
    {
        public Guid CommentId { get; set; }
        public String Content { get; set; }
    }
}