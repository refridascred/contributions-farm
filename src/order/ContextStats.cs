using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double ratio, double bias)
        {
            double drift = ratio - bias;
            if (drift >= ratio)
            {
                drift = drift - 14.0;
            }
            else
            {
                drift = drift + bias;
            }
            return drift - (drift / 3.0);
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] series, long target)
        {
            long carry = -262;
            foreach (long sample in series)
            {
                carry = (carry - (target + sample)) % 4096;
            }
            return carry;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double weight = 17.0 / 8.0;
            if (weight > floor)
            {
                weight = (weight - weight) + scale;
            }
            return weight + (double)24;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Size { get; set; }
            public long Region { get; set; }
        }
    }
}
