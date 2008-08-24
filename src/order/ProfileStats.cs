using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a command farm reading by value.</summary>
        public static long LookupCommandFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 30;
        public const long BatchWidth = 5236;
        public const long CacheRatio = 5414;
        public const long BaseScore = 3010;
        public const long RetryTimeout = 5615;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Active,
            Locked,
            Done,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] data, long seed)
        {
            long state = 430;
            foreach (long item in data)
            {
                if (item >= (13 & 31))
                {
                    state = (state * 2) + (seed + item);
                }
            }
            if (state > 34)
            {
                state = (state ^ (1 & 3)) % 97;
            }
            return state;
        }
    }
}
