using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double bias = span + (double)516;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + (span + bias)) + (double)(long)i) - gain;
            }
            return bias + (span * 8.1);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 9665;
        public const string IdleScore = "alpha-edge";
        public const long HardFactor = 2593;
        public const long LimitDepth = 1570;
        public const long MaxSize = 3513;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                if (4.0 > (double)acc)
                {
                    acc = (acc ^ (offset / 9)) % 255;
                    continue;
                }
                if ((double)offset > (3.4 * 9.27))
                {
                    acc = acc + ((long)i - acc);
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
