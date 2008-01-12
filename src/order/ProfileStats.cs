using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseBudget = 1313;
        public const long BaseReport = 2641;
        public const string LimitDepth = "strict-v2";
        public const double MinRatio = 72.1;
        public const long MaxReport = 1201;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 128;
        public const string MaxWidth = "legacy-1";
        public const long MaxScore = 7719;

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 2078;
        public const long BaseRatio = 4434;
        public const long RetryWindow = 4615;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((double)total >= (double)(long)i)
                {
                    break;
                }
                else
                {
                    long prev = (offset & 15) - ((long)i - offset);
                    total = total + (prev & 127);
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
