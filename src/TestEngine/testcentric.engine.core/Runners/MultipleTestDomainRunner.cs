// ***********************************************************************
// Copyright (c) Charlie Poole and TestCentric Engine contributors.
// Licensed under the MIT License. See LICENSE.txt in root directory.
// ***********************************************************************

#if !NETSTANDARD1_6 && !NETSTANDARD2_0
using NUnit.Engine;

namespace TestCentric.Engine.Runners
{
    /// <summary>
    /// MultipleTestDomainRunner runs tests using separate
    /// application domains for each assembly.
    /// </summary>
    public class MultipleTestDomainRunner : AggregatingTestRunner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleTestDomainRunner"/> class.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="package">The package.</param>
        public MultipleTestDomainRunner(IServiceLocator services, TestPackage package) : base(services, package) { }

        protected override ITestEngineRunner CreateRunner(TestPackage package)
        {
            return new TestDomainRunner(Services, package);
        }
    }
}
#endif
