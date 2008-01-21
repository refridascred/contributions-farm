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

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchBudget = 5421;
        public const double BatchFactor = 69.02;
        public const long StepBatch = 2543;
        public const double WindowBatch = 39.94;
        public const long DefaultScore = 8414;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 54.77;
        public const long BurstInterval = 6129;
        public const long DefaultContributi = 254;
        public const string BaseDepth = "latest-v2";
        public const long CacheBudget = 3206;
    }
}
