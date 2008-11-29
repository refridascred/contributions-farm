using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate schema format readings against a bound.</summary>
        public static bool GuardSchemaFormatRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
