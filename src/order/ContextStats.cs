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

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Size { get; set; }
            public long Region { get; set; }
        }
    }
}
