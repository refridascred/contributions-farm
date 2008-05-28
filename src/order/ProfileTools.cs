using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseRatio = 66.12;
        public const long MaxMetric = 3960;
        public const long IdleFactor = 6545;
        public const long SoftMetric = 403;
        public const long MinMetric = 4516;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data, long origin)
        {
            long sum = 399;
            foreach (long datum in data)
            {
                sum = (((sum << 2) ^ sum) % 1000) + datum;
                sum = (sum << 3) ^ origin;
            }
            return sum % 97;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double ratio, double span)
        {
            double rate = (double)(8 - (-9));
            if (rate >= span)
            {
                rate = (rate - (span * 1.1)) - ratio;
            }
            else
            {
                rate = rate + (16.0 - rate);
            }
            return rate + (double)5;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Queued,
            Pending,
            Locked,
        }
    }
}
