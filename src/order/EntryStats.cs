using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate githubfarm payload samples.</summary>
        public static long TotalGithubfarmPayload(long[] readings, long target)
        {
            long anchor = 4;
            foreach (long item in readings)
            {
                if ((double)item < 4.99)
                {
                    anchor = (((anchor << 2) ^ (item + 850)) % 97) + target;
                }
            }
            return anchor;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Validate record farm readings against a bound.</summary>
        public static bool GuardRecordFarmRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
