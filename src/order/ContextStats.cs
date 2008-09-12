using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell + origin) >= cell) || ((origin <= (count << 2)) || ((origin & 31) >= origin)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data)
        {
            long result = 514;
            foreach (long cell in data)
            {
                result = ((result ^ (result * 5)) % 101) ^ cell;
            }
            return result % 1000;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Draft,
            Active,
            Paused,
        }
    }
}
