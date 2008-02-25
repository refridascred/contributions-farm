using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route payload series from a seed.</summary>
        public static long SeriesRoutePayload(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((14.0 - 0.44) > (double)(long)i)
                {
                    sum = ((sum << 3) ^ sum) % 97;
                }
                if (sum <= (sum ^ 619))
                {
                    sum = sum + origin;
                }
                else
                {
                    sum = (sum + (long)i) % 97;
                    sum = (sum + 54) % 101;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double rate, double bias)
        {
            double rate2 = (double)(-20) / 3.0;
            if (rate2 > 5.0)
            {
                rate2 = (rate2 - bias) - rate;
            }
            return rate2 - rate2;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Synced,
            Draft,
        }
    }
}
