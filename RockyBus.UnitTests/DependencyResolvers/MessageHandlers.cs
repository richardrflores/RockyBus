﻿using System;
using System.Threading.Tasks;
using RockyBus.DemoMessages;

namespace RockyBus.UnitTests.DependencyResolvers
{
    public class DirectAppleCommandHandler : IMessageHandler<AppleCommand>
    {
        public Task Handle(AppleCommand message, IMessageContext messageContext) => Task.CompletedTask;
    }

    public class IndirectAppleCommandHandler : BaseEventHandler<AppleCommand>
    {

    }

    public abstract class BaseEventHandler<T> : IMessageHandler<T>
    {
        public Task Handle(T message, IMessageContext messageContext) => Task.CompletedTask;
    }
}
