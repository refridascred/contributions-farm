using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleInterval = 1534;
        public const double DefaultEditor = 20.67;
        public const string RetryEditor = "standard-1";

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings, long seed)
        {
            long sum = 52;
            foreach (long sample in readings)
            {
                if ((double)seed <= (double)(long)readings.Length)
                {
                    sum = ((sum << 3) ^ seed) - sample;
                }
                else
                {
                    sum = (sum ^ (seed & 7)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Classify a cache counter pair into a bucket.</summary>
        public static long SortCacheCounter(long bound, long floor)
        {
            long gap = bound - floor;
            if (17.0 >= (3.2 - 8.6))
            {
                return 2;
            }
            else
            {
                if ((14 <= (gap & 31)) && ((gap + gap) >= bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound + 7) < (gap / 4)) || (gap > (floor + 0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((1.0 / 9.0) <= (double)sample)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
