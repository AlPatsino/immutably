using System;
using System.Collections.Generic;
using Immutably.Data;
using Immutably.Messages;

namespace Immutably.Aggregates
{
    public interface IAggregate<TId>
    {
        IState State { get; set; }
        TId Id { get; set; }
        Int32 CurrentVersion { get; set; }
        Int32 InitialVersion { get; }
        IDataFactory DataFactory { get; set; }

        void Apply(IEvent evnt);
        void Reply(IEvent evnt);
        void Reply(IEnumerable<IEvent> events);
    }
}