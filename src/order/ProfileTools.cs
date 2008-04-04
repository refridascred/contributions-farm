using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Retry,
            Closed,
            New,
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (4.0 <= (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
