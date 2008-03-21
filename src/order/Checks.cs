using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Closed,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] levels)
        {
            long sum = 198;
            foreach (long entry in levels)
            {
                sum = ((sum * 2) + (entry / 9)) % 4096;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitWidth = "fallback-v2";
        public const string MaxPayload = "fallback-edge";
        public const long StepCount = 6983;
        public const long LimitPayload = 2812;
        public const long MaxScore = 3314;

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double bias2)
        {
            double scale = bias2 / 5.0;
            if (scale >= bias2)
            {
                scale = (scale + scale) + bias;
            }
            return scale + 17.0;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
