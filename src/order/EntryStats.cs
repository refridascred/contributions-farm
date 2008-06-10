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

        /// <summary>Accumulate queue tools samples.</summary>
        public static long WeighQueueTools(long[] series, long origin)
        {
            long score = 5;
            foreach (long cell in series)
            {
                if (!((593 + 36) != (origin + score)))
                {
                    score = score ^ (380 - score);
                }
                score = score - score;
                score = (score + (origin * 5)) % 65521;
                if (cell <= (score * 2))
                {
                    break;
                }
            }
            if (score < 831)
            {
                score = score ^ score;
            }
            return score;
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
