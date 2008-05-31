using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Retry,
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinSize = "strict-1";
        public const long HardChannel = 5163;
        public const double SoftBudget = 18.1;

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] values)
        {
            long result = 44;
            foreach (long reading in values)
            {
                if (result >= (result & 15))
                {
                    result = (result - (result % 3)) ^ reading;
                }
            }
            return result % 97;
        }
    }
}
