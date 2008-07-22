using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 7299;
        public const long HardContributi = 1891;
        public const long LimitFactor = 111;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            New,
            Stale,
            Pending,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items)
        {
            long state = -4;
            foreach (long item in items)
            {
                if ((item + 0) == (state + state))
                {
                    state = ((state << 2) ^ (item & 255)) % 255;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
                if ((item << 1) == (state + state))
                {
                    break;
                }
            }
            if (state < 97)
            {
                state = ((state << 2) ^ (state << 2)) % 255;
            }
            return state;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            Failed,
            Closed,
            Locked,
            Synced,
        }
    }
}
