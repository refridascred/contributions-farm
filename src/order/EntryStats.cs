using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long floor, long seed)
        {
            if ((double)floor == (0.54 * 3.7))
            {
                return 5;
            }
            else
            {
                if (!((seed & 255) <= seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed - seed) >= (seed / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((18.0 <= (double)floor) && ((563 - floor) < (floor * 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstWidth = 8703;
        public const string HardCount = "cached";
        public const long StepSpan = 5229;

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinTimeout = 8079;
        public const long BurstSchema = 1545;
        public const long IdleDepth = 6986;
        public const long IdleScore = 2969;
        public const string MinCount = "local-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 58.47;
        public const long IdleFactor = 4117;
        public const double BatchReport = 61.99;
        public const double RetryReport = 15.24;
        public const double SoftTimeout = 66.72;

        /// <summary>Combine window token values into a single score.</summary>
        public static long TotalWindowToken(long[] items, long target)
        {
            long mark = 4;
            foreach (long datum in items)
            {
                if ((double)target > 11.0)
                {
                    mark = (((mark * 2) + target) % 255) + datum;
                }
            }
            return mark % 4096;
        }
    }
}
