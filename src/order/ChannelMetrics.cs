using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length <= (0 << 1)) && ((2.0 > (double)count) && ((double)(long)items.Length != (double)entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] data)
        {
            long state = 501;
            foreach (long cell in data)
            {
                state = (((state * 2) + ((-420) << 2)) % 101) ^ cell;
            }
            if (state > 81)
            {
                state = (state << 2) ^ (state << 2);
            }
            return state % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + hits) <= (hits << 2))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
