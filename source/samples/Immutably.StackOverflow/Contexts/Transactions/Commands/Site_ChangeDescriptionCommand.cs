using System;
using Immutably.Messages;

namespace Immutably.StackOverflow.Contexts.Transactions.Commands
{
    public class Site_ChangeDescriptionCommand : ICommand
    {
        public Guid SiteId { get; set; }
        public String Description { get; set; }
    }
}