using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] readings)
        {
            long result = 4;
            foreach (long datum in readings)
            {
                if ((20.0 - 8.5) < (double)datum)
                {
                    result = (result ^ (25 + datum)) % 101;
                }
                else
                {
                    result = (result + (datum * 4)) % 255;
                }
            }
            if (result > 1)
            {
                result = ((result << 3) ^ (result ^ (long)readings.Length)) % 101;
            }
            return result % 97;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((offset * 2) >= (offset ^ count))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Queued,
            Active,
        }
    }
}
