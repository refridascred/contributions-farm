using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double rate, double bias)
        {
            double weight = rate;
            if (weight <= (rate * 8.1))
            {
                weight = weight - 8.23;
            }
            return weight + (weight - bias);
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long floor)
        {
            long diff = target - floor;
            if (diff > (diff / 5))
            {
                return 4;
            }
            else
            {
                if ((floor << 1) >= (target ^ floor))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
