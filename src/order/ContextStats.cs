using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a account stats reading by value.</summary>
        public static long LookupAccountStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (8.25 < (double)count)
                {
                    count = ((count + 3) - item) - origin;
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Active,
            New,
        }
    }
}
