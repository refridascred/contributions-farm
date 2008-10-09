using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long origin, long floor)
        {
            if ((floor + floor) == (origin / 6))
            {
                return 2;
            }
            else
            {
                if ((double)floor > (8.0 / 6.0))
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 1) == (origin + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "staging";
        public const string BatchCount = "local-edge";
        public const long BatchAccount = 5441;
        public const string BaseAccount = "open-v2";

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 1404;
        public const string StepCounter = "stable-v2";
        public const string RetrySize = "primary";
        public const long WindowFactor = 6404;
    }
}
