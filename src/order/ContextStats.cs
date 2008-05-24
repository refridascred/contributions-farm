using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 6666;
        public const long MinInterval = 3770;
        public const double MaxRoute = 8.43;
        public const long MinRoute = 6745;
        public const long LimitDepth = 5905;

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] items)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                mix = ((mix - (mix << 2)) % 65521) ^ datum;
            }
            return mix;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Active,
            Queued,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double bias2 = (bias + bias) * 15.0;
            if (bias2 >= (bias2 + bias))
            {
                bias2 = (bias2 + (bias2 + bias)) - ratio;
            }
            return bias2 + bias;
        }
    }
}
