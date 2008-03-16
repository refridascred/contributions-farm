using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two account farm measurements.</summary>
        public static double ProjectAccountFarm(double weight, double span)
        {
            double bias = span;
            if (bias <= (double)58)
            {
                bias = (bias + 7.0) - weight;
            }
            else
            {
                bias = bias - span;
            }
            return bias + span;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double weight, double bias)
        {
            double load = 8.6;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (weight * 2.7)) + (double)(long)i) + bias;
            }
            return load + (weight - load);
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Idle,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Stale,
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long sum = 16;
            foreach (long value in data)
            {
                if ((value - sum) >= sum)
                {
                    sum = ((sum << 3) ^ 7) % 65521;
                }
            }
            if (sum > 7)
            {
                sum = ((sum * 3) + (sum & 7)) % 4096;
            }
            return sum % 4096;
        }
    }
}
