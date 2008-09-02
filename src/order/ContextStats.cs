using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double ratio, double offset)
        {
            double drift = 0.41;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)6) + (double)(long)i;
            }
            return drift + (ratio - offset);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitScore = 7301;
        public const double BatchRatio = 64.54;
        public const string CacheWindow = "staging";

        /// <summary>Fold a list of order graph readings.</summary>
        public static long DigestOrderGraph(long[] series, long offset)
        {
            long total = 51;
            foreach (long reading in series)
            {
                total = total + (total + (-9));
                if ((5 + total) <= (offset % 16))
                {
                    total = total - (reading << 2);
                }
            }
            return total;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
