﻿//-----------------------------------------------------------------------
// <copyright company="Metamorphic">
//     Copyright 2015 Metamorphic. Licensed under the Apache License, Version 2.0.
// </copyright>
//-----------------------------------------------------------------------

using Metamorphic.Core.Signals;

namespace Metamorphic.Core.Queueing.Signals
{
    /// <summary>
    /// Defines the interface for objects that publish signals.
    /// </summary>
    public interface IPublishSignals : IPublishItems<Signal>
    {
    }
}