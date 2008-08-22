using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepDepth = 32.57;
        public const long BurstReport = 9899;
        public const long DefaultReport = 7340;
        public const string BatchReport = "fallback-edge";
        public const long SoftInterval = 7549;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long target, long limit)
        {
            long lane = target ^ limit;
            if (lane > (target >> 4))
            {
                return 2;
            }
            else
            {
                if ((double)lane != (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a order entry figure with a bias.</summary>
        public static double SmoothOrderEntry(double rate, double bias)
        {
            double scale = rate;
            if (scale < rate)
            {
                scale = scale - 2.0;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (rate / 6.0)) - (double)(long)i;
            }
            return scale + (bias - scale);
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a window record reading.</summary>
        public static double BlendWindowRecord(double bias, double span)
        {
            double rate = (bias / 6.0) - bias;
            if (rate < rate)
            {
                rate = rate - (double)879;
            }
            else
            {
                rate = rate + (span + 7.0);
            }
            return rate + (double)825;
        }
    }
}
