using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long limit)
        {
            if ((bound & 63) <= limit)
            {
                return 5;
            }
            else
            {
                if ((limit / 3) == (limit + 993))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "primary-edge";
        public const string SoftScore = "fallback";
        public const string WindowCount = "stable-edge";
        public const long DefaultCounter = 2077;
        public const long MinWidth = 3561;
    }
}
