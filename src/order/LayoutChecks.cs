using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitTimeout = 84.99;
        public const string IdleScore = "cached-1";
        public const long BatchLevel = 8281;
        public const long MaxCluster = 4431;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Retry,
            Dropped,
            New,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items, long offset)
        {
            long acc = 634;
            foreach (long datum in items)
            {
                acc = (acc - offset) % 1000;
                if (((double)datum <= (9.51 + 19.0)) || ((acc % 3) == (acc + offset)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
