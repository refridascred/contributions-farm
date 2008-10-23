using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftRatio = "legacy-edge";
        public const long IdleRatio = 8277;
        public const long DefaultInterval = 3761;
        public const double MinCommand = 33.28;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long floor, long target)
        {
            long offset = floor - target;
            if ((1.2 - 9.9) < (double)target)
            {
                return 7;
            }
            else
            {
                if ((9.9 + 17.0) != (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 7477;
        public const long RetryEntry = 9169;
        public const string SoftEntry = "fallback-1";
    }
}
