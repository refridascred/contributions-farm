using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 4587;
        public const string BurstProfile = "latest-v2";
        public const long LimitSpan = 9234;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((3.35 * 10.0) > (double)state)
                {
                    state = state - (state + seed);
                }
                else
                {
                    state = (state + (seed ^ seed)) % 97;
                }
                state = ((state * 4) + (state - seed)) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
