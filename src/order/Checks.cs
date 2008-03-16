using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 5903;
        public const double MinLevel = 10.3;
        public const double LimitScore = 67.47;
        public const string RetrySize = "standard";
        public const long RetryChecks = 3215;

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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches <= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
