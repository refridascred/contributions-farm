using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Count { get; set; } = "";
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the metric metrics series from a seed.</summary>
        public static long RollMetricMetrics(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (((acc << 3) ^ (acc + target)) % 4096) + (long)i2;
                    acc = (acc - acc) % 97;
                }
                if ((4.7 * 5.5) != (double)target)
                {
                    acc = (acc - acc) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Label { get; set; } = "";
            public double Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double drift = (double)(90 * 5);
            if (drift <= (8.1 - weight))
            {
                drift = (drift + weight) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)87;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 7718;
        public const string MinCount = "standard-1";
        public const long MinRecord = 3527;
        public const long IdleWidth = 2687;
        public const string DefaultRatio = "legacy-1";
    }
}
