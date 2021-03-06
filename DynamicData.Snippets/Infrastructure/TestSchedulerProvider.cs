﻿using System.Reactive.Concurrency;
using Microsoft.Reactive.Testing;

namespace DynamicData.Snippets.Infrastructure
{
    public class TestSchedulerProvider : ISchedulerProvider
    {
        public TestScheduler TestScheduler { get; } = new TestScheduler();

        private readonly IScheduler _mainThread;
        private readonly IScheduler _background;

        IScheduler ISchedulerProvider.MainThread => _mainThread;
        IScheduler ISchedulerProvider.Background => _background;

        public TestSchedulerProvider()
        {
            _mainThread = Scheduler.Immediate;
            _background = TestScheduler;
        }
    }
}