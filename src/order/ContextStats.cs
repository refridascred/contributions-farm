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

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double span)
        {
            double gain2 = (double)(4 % 10);
            if (gain2 < gain2)
            {
                gain2 = gain2 - (gain / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - (span - gain)) + (double)(long)i;
            }
            return gain2 - (gain2 / 7.0);
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
