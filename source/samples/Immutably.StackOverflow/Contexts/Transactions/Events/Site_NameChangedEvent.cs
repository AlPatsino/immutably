using System;
using Immutably.Messages;

namespace Immutably.StackOverflow.Contexts.Transactions.Events
{
    public class Site_NameChangedEvent : IEvent
    {
        public Guid SiteId { get; set; }
        public String Name { get; set; }
    }
}