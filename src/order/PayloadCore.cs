using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Score { get; set; } = "";
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Stale,
            Pending,
            Dropped,
            New,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Closed,
            Active,
        }
    }
}
