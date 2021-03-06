using System;
using Immutably.Data;
using Machine.Specifications;

namespace Immutably.Tests.Data
{
    public class when_data_context_created_with_types_from_assembly : DataMachineContext
    {
        Because of = () =>
        {
            context = DataContext.Create(builder => builder
                .AddAssemblyContracts(typeof(DataMachineContext).Assembly, "Immutably.Tests.Data")
                .AddAssemblyProxies(typeof(DataMachineContext).Assembly, "Immutably.Tests.Data")
            );
        };

        It should_correctly_find_proxy_type = () =>
            context.GetProxy(typeof (User)).ShouldEqual(typeof(User_Bson));

        It should_return_correct_tag_for_contract = () =>
            context.GetTag(typeof(User)).ShouldEqual(Guid.Parse("{40952BD5-993B-4706-9442-099C9AD8E33F}"));

        It should_return_correct_tag_for_proxy = () =>
            context.GetTag(typeof(User_Bson)).ShouldEqual(Guid.Parse("{40952BD5-993B-4706-9442-099C9AD8E33F}"));

        private static IDataContext context;
    }
}