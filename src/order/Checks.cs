using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine order support values into a single score.</summary>
        public static long ScoreOrderSupport(long[] samples, long target)
        {
            long carry = 33;
            foreach (long entry in samples)
            {
                carry = ((carry - (target / 8)) % 4096) ^ entry;
            }
            if (carry > 897)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 47.29;
        public const long RetrySize = 5968;
        public const string BatchScore = "local";

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double drift = 7.0;
            if (drift <= 7.6)
            {
                drift = (drift + gain) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (9.5 * 18.0)) - (double)(long)i;
            }
            return drift - (double)11;
        }
    }
}
