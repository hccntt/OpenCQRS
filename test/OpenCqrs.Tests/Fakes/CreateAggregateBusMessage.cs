﻿using System;
using OpenCqrs.Bus;
using OpenCqrs.Domain;

namespace OpenCqrs.Tests.Fakes
{
    public class CreateAggregateBusMessage : DomainCommand, IBusQueueMessage
    {
        public DateTime? ScheduledEnqueueTimeUtc { get; set; }
        public string QueueName { get; set; } = "create-something";
    }
}
