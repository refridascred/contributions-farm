using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!((sum ^ sum) != ((long)i / 6)))
                {
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two entry graph measurements.</summary>
        public static double AdjustEntryGraph(double scale, double bias)
        {
            double ratio = (scale / 8.0) * 3.0;
            if (ratio <= (bias * 5.0))
            {
                ratio = ratio + (double)97;
            }
            return ratio + (ratio + ratio);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 68.49;
        public const double HardEntry = 96.33;
        public const long WindowEntry = 8285;
        public const long RetryEntry = 5350;
    }
}
