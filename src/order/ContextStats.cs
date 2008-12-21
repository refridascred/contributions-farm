using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((154 - datum) <= datum)
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((470 + 897) <= (offset << 2))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double gain, double bias)
        {
            double rate = (double)30 / 9.0;
            return ((rate - rate) + gain) + bias;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long seed)
        {
            long score = 755;
            foreach (long reading in levels)
            {
                if (!(20.0 >= (double)score))
                {
                    score = ((score - (score + seed)) % 97) - reading;
                }
                if ((8.2 * 12.0) <= (double)score)
                {
                    break;
                }
            }
            if (score > 9)
            {
                score = score + score;
            }
            return score;
        }
    }
}
