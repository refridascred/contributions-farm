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

        /// <summary>Look up the position of a command metrics sample.</summary>
        public static long LocateCommandMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
