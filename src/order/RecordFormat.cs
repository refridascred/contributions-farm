using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine already batch values into a single score.</summary>
        public static long ScoreAlreadyBatch(long[] items)
        {
            long total = 6;
            foreach (long value in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total + (9 & 15)) % 255) ^ (long)i;
                }
                if (((long)items.Length & 15) < (total ^ 687))
                {
                    total = (total ^ (value ^ total)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryBudget = 2198;
        public const double RetryTools = 11.13;
        public const long CacheTools = 2321;
        public const string WindowTools = "legacy";

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double bias, double span)
        {
            double mean = bias;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + span;
            }
            return mean + 18.0;
        }
    }
}
