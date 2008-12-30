using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            New,
            Locked,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Dropped,
            New,
            Queued,
            Retry,
        }
    }
}
