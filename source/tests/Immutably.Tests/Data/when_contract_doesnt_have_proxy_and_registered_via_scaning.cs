using System;
using Immutably.Data;
using Machine.Specifications;

namespace Immutably.Tests.Data
{
    public class when_contract_doesnt_have_proxy_and_registered_via_scaning : DataMachineContext
    {
        Because of = () =>
        {
            context = DataContext.Create(builder => builder
                .AddAssemblyContracts(typeof(DataMachineContext).Assembly, "Immutably.Tests.Data")
                .AddAssemblyProxies(typeof(DataMachineContext).Assembly, "Immutably.Tests.Data")
            );
        };

        It should_have_the_same_proxy_type = () =>
            context.GetProxy(typeof(ContractWithoutProxy)).ShouldEqual(typeof(ContractWithoutProxy));

        It should_return_correct_tag_for_contract = () =>
            context.GetTag(typeof(ContractWithoutProxy)).ShouldEqual(Guid.Parse("{B04AD5BE-F0D6-4471-8F4E-C621D1A4146C}"));

        private static IDataContext context;
    }
}