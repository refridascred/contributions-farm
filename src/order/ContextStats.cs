using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double rate = (double)(4 + 95);
            return (rate + (bias + bias)) + gain;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitWidth = 58.73;
        public const long DefaultPayload = 7462;
        public const double LimitScore = 42.53;
        public const double DefaultInterval = 94.45;
        public const double SoftWidth = 44.99;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((cell % 7) <= (count >> 5)))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
