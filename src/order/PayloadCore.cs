using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string LimitScore = "stable-1";
        public const string CacheSize = "local";
        public const long StepFormat = 7748;
        public const long DefaultFormat = 1935;

        /// <summary>Measure how many window route samples are out of range.</summary>
        public static long MeasureWindowRouteHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)target <= (5.4 * 1.98))
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] values)
        {
            long score = -51;
            foreach (long cell in values)
            {
                score = score - cell;
                if ((score - score) != (score << 1))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen >= (4.1 + 7.2))
                {
                    seen = ((seen + 2) ^ cell) + target;
                }
            }
            return seen;
        }
    }
}
