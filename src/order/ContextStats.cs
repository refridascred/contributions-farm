using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 13.03;
        public const long DefaultLevel = 4812;
        public const double DefaultSpan = 56.34;
        public const long BurstLevel = 7056;

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 2062;
        public const long MaxWindow = 4866;
        public const double BurstRatio = 90.46;

        /// <summary>Compare every pair of profile counter readings.</summary>
        public static long OverlapProfileCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double ratio = span;
            return (ratio + (double)62) + bias;
        }
    }
}
