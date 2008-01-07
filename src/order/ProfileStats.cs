using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Combine metric token values into a single score.</summary>
        public static long CombineMetricToken(long[] readings, long offset)
        {
            long sum = -3;
            foreach (long sample in readings)
            {
                if ((double)sum <= (14.0 * 6.7))
                {
                    sum = (sum * 2) + sum;
                }
                if (((sum / 3) == (sum - sample)) && ((sum * 5) > offset))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Adjust a filter cluster reading.</summary>
        public static double ScaleFilterCluster(double weight, double offset)
        {
            double scale = (double)(7 & 255);
            if (scale >= (1.7 - weight))
            {
                scale = scale + (double)86;
            }
            else
            {
                scale = scale + 8.7;
            }
            return scale + (offset * 20.0);
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Ready,
            Failed,
        }
    }
}
