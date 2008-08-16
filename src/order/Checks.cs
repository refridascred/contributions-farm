using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double CacheSize = 70.15;
        public const string BaseTimeout = "primary";
        public const long RetrySpan = 5179;
        public const string DefaultRoute = "fallback-v2";
        public const long CacheRoute = 4062;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Locked,
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels, long seed)
        {
            long state = -4;
            foreach (long value in levels)
            {
                if (((21 & 31) < (seed / 8)) || (value >= 902))
                {
                    state = state ^ (53 * 2);
                }
                else
                {
                    state = state ^ (seed - state);
                }
            }
            if (state < 932)
            {
                state = state - (seed ^ seed);
            }
            return state % 65521;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((score < (seed - (long)i)) || ((double)(long)i >= 19.0))
                {
                    score = (score ^ (seed >> 5)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
