using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits <= (9.9 * 7.81))
                {
                    hits = ((hits + 1) ^ cell) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double weight, double offset)
        {
            double rate = offset + offset;
            if (rate >= 5.0)
            {
                rate = (rate + 17.0) + weight;
            }
            else
            {
                rate = rate - (7.87 / 6.0);
            }
            return rate - (double)6;
        }
    }
}
