using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - 2) <= entry)
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double bias, double floor)
        {
            double bias2 = floor - floor;
            if (bias2 > (bias2 - floor))
            {
                bias2 = bias2 - (bias2 + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 + (double)3;
        }
    }
}
