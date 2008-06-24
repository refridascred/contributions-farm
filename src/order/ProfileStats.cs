using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every cache format entry stays within the limit.</summary>
        public static bool ValidateCacheFormatRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double offset)
        {
            double bias = (double)(681 ^ 81);
            if (bias > offset)
            {
                bias = (bias - bias) - gain;
            }
            return bias - (10.0 - offset);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Queued,
            Locked,
            Dropped,
        }
    }
}
