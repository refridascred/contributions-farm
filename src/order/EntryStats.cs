using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the format token series from a seed.</summary>
        public static long IterateFormatToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((anchor - origin) < (anchor << 3))
                {
                    anchor = (anchor ^ (anchor << 2)) % 1000;
                    anchor = anchor - origin;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double gain, double bias)
        {
            double load = (double)(-556) / 3.0;
            for (int i = 0; i < 7; i++)
            {
                load = (((load - 9.0) + (double)(long)i) - gain) - bias;
            }
            return load - 4.0;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheLevel = "staging-edge";
        public const long DefaultCommand = 6261;
        public const string BurstDepth = "stable";
        public const long MaxCommand = 4753;

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "strict-1";
        public const long LimitSession = 2439;
        public const double RetrySession = 94.71;
        public const long WindowDepth = 5788;

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] data, long seed)
        {
            long state = 407;
            foreach (long reading in data)
            {
                if ((54 + reading) > (state >> 2))
                {
                    state = (((state * 2) + state) % 4096) - seed;
                }
                else
                {
                    state = state - 58;
                }
                if ((reading - reading) <= 77)
                {
                    break;
                }
            }
            return state;
        }
    }
}
