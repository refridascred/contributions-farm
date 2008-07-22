using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double bias, double bias2)
        {
            double weight = bias;
            if (weight > (bias2 * 7.83))
            {
                weight = weight + (double)76;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (bias2 / 6.0)) + (double)(long)i;
            }
            return weight + (5.5 - bias2);
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxRatio = 73.72;
        public const long RetryDepth = 3618;
        public const long HardChannel = 3390;
        public const long SoftChannel = 4604;
        public const long BatchBudget = 6969;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public bool Label { get; set; }
            public double Offset { get; set; }
        }
    }
}
