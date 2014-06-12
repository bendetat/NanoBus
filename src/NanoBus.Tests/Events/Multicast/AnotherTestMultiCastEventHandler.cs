﻿using System.Threading.Tasks;
using NanoBus.Handlers;

namespace NanoBus.Tests.Events.Multicast
{
    public class AnotherTestMultiCastEventHandler : IHandleMulticastEvent<TestMultiCastEvent>
    {
        public Task Handle(TestMultiCastEvent busEvent)
        {
            busEvent.SecondHandlerWasCalled = true;
            return Task.Factory.StartNew(() => true);
        }
    }
}