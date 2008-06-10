using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCount = 381;
        public const double RetryCount = 96.02;
        public const long StepCache = 2531;

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseCount = 19.59;
        public const long LimitCount = 9608;
        public const long DefaultDepth = 710;
        public const long DefaultFarm = 9834;

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (((result * 2) + (offset + (long)i)) % 101) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the stats graph entries that pass the check.</summary>
        public static long AuditStatsGraphOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(seed >= (value >> 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double bias = 2.87;
            for (int i = 0; i < 3; i++)
            {
                bias = (((bias - bias) + (double)(long)i) + scale) - span;
            }
            return bias - (double)826;
        }
    }
}
