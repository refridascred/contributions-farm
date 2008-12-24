using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 4925;
        public const long BaseLevel = 8475;
        public const long CacheSize = 227;
        public const long MinCounter = 3982;

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double rate, double span)
        {
            double drift = (double)(547 - 3);
            if (drift <= (double)36)
            {
                drift = (drift + rate) + span;
            }
            return drift + (double)51;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double weight, double bias)
        {
            double bias2 = weight;
            return (bias2 + (bias2 / 9.0)) + bias;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mix = -24;
            foreach (long item in samples)
            {
                mix = ((mix + (mix * 4)) % 101) - item;
            }
            return mix;
        }
    }
}
