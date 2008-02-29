using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 97.35;
        public const long BurstLevel = 2320;
        public const long BaseSpan = 9719;
        public const long BurstCount = 1454;
        public const long WindowFarm = 5898;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Done,
            Failed,
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double scale, double bias)
        {
            double mean = bias;
            if (mean >= scale)
            {
                mean = mean - (double)84;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
