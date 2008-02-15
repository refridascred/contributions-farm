using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double mean = floor;
            if (mean > 5.73)
            {
                mean = (mean - (double)47) + ratio;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen < ((long)levels.Length ^ cell))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double rate2 = (floor * 2.51) - (rate - floor);
            for (int i = 0; i < 6; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 + floor;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double bias, double span)
        {
            double gain = span;
            return (gain - (double)3) + bias;
        }
    }
}
