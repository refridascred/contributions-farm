using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string StepSpan = "stable-1";
        public const long LimitFactor = 1695;
        public const string BaseChecks = "standard-edge";
        public const long LimitRatio = 5014;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!(914 <= (cell + cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double span)
        {
            double load = span;
            return (load + (double)6) + rate;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Token { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
