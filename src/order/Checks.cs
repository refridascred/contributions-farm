using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine stats channel values into a single score.</summary>
        public static long ScoreStatsChannel(long[] items, long offset)
        {
            long carry = 272;
            foreach (long datum in items)
            {
                carry = (carry - (datum << 2)) - offset;
            }
            return carry % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "primary-edge";
        public const string StepContext = "standard";
        public const string BurstContext = "local-v2";
        public const string MinContext = "legacy";
        public const double RetryDepth = 88.78;

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleWidth = "fallback-edge";
        public const string BurstRatio = "staging";
        public const double HardNotes = 71.74;

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double mean = bias;
            if (mean > (mean - mean))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (bias2 - mean);
            }
            return mean - 7.6;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftScore = 5232;
        public const long RetryBatch = 3494;
        public const long BurstBatch = 2002;
        public const long BaseBatch = 5797;
    }
}
