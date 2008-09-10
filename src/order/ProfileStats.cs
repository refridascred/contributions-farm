using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next stats record value.</summary>
        public static double BlendStatsRecord(double scale, double span)
        {
            double scale2 = scale - span;
            if (scale2 >= (double)7)
            {
                scale2 = scale2 - (scale - scale2);
            }
            return scale2 - scale2;
        }

        /// <summary>Audit queue editor readings against a rule.</summary>
        public static long MeasureQueueEditorMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!(((origin + origin) == (origin * 5)) && ((origin - origin) < (origin % 2))))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + value) >= (hits & 63))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((0.5 - 0.81) <= (double)count)
                {
                    count = ((count + 1) + item) - step;
                }
            }
            return count;
        }
    }
}
