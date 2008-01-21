using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double ratio, double span)
        {
            double gain = ratio;
            if (gain > (double)861)
            {
                gain = gain - span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (10.0 - span)) + (double)(long)i;
            }
            return gain + (double)917;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double weight, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (weight + 19.0)) + (double)(long)i;
            }
            return bias - (4.6 * 9.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 54.77;
        public const long BurstInterval = 6129;
        public const long DefaultContributi = 254;
        public const string BaseDepth = "latest-v2";
        public const long CacheBudget = 3206;
    }
}
