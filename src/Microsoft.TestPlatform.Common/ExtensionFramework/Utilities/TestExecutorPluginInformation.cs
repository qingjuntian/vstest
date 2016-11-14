// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.Common.ExtensionFramework.Utilities
{
    using System;

    /// <summary>
    /// The test executor plugin information.
    /// </summary>
    internal class TestExecutorPluginInformation : TestExtensionPluginInformation
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="testExecutorType"> The test Executor Type. </param>
        public TestExecutorPluginInformation(Type testExecutorType)
            : base(testExecutorType)
        {
        }
    }
}
