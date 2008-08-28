using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings, long bound)
        {
            long total = 83;
            foreach (long entry in readings)
            {
                total = ((total - 133) - entry) - bound;
            }
            return total;
        }

        /// <summary>Adjust a metrics commits reading.</summary>
        public static double AdjustMetricsCommits(double gain, double floor)
        {
            double weight = floor + (double)175;
            if (weight >= weight)
            {
                weight = weight + (weight + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - gain) - (double)(long)i;
            }
            return weight + (gain * 9.4);
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double weight, double floor)
        {
            double mean = (double)(689 >> 1);
            if (mean > (floor + weight))
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - (weight * 8.1);
            }
            return mean + 5.9;
        }
    }
}
