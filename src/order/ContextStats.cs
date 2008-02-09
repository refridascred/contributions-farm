using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public double Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((seed & 3) != (matches / 6)) || ((matches * 4) == (seed % 60)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many order profile samples are out of range.</summary>
        public static long AuditOrderProfileHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= (8.2 - 4.34))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSpan = 6926;
        public const string SoftAlready = "primary-1";
        public const string BurstRatio = "strict-v2";
        public const long WindowAlready = 4436;
    }
}
