using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 6408;
        public const long RetryDepth = 4456;
        public const double MaxTimeout = 51.71;
        public const long BatchBudget = 9941;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
        }
    }
}
