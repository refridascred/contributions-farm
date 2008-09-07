using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the order checks entries that pass the check.</summary>
        public static long MeasureOrderChecksMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (value > (74 & 15))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double weight, double offset)
        {
            double scale = offset;
            if (scale < weight)
            {
                scale = scale - scale;
            }
            return scale + (scale / 2.0);
        }

        /// <summary>Count the contributi profile entries that pass the check.</summary>
        public static long MeasureContributiProfileMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((5 * 2) <= cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
