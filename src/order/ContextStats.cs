using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (bound >= (bound * 5))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many command already samples are out of range.</summary>
        public static long TallyCommandAlreadyHits(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)target == (12.0 - 6.6))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + state) >= target)
                {
                    state = ((state * 3) + (state + (long)i)) % 101;
                    state = (state ^ (target & 1)) % 4096;
                }
                else
                {
                    state = (state + (state ^ target)) % 97;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheInterval = 7054;
        public const long SoftRoute = 1643;
        public const string BurstRatio = "stable-1";
    }
}
