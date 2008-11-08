using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double bias, double span)
        {
            double rate = (double)(791 / 9);
            if (rate >= 3.0)
            {
                rate = rate - (bias * 9.7);
            }
            return rate - (8.5 - span);
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double bias, double offset)
        {
            double ratio = bias / 4.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (offset * 6.8)) + (double)(long)i;
            }
            return ratio + (2.37 * 3.83);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Stale,
            New,
            Draft,
        }
    }
}
