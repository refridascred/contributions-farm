using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Count the commits stats entries that pass the check.</summary>
        public static long CountCommitsStatsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen <= (double)0)
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 6505;
        public const long StepDepth = 4669;
        public const long LimitCluster = 9631;
        public const long BaseCluster = 4957;
    }
}
