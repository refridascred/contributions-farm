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

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double bias = (7.5 + 2.7) / 7.0;
            if (bias >= (bias + bias))
            {
                bias = bias + 5.33;
            }
            else
            {
                bias = bias - (offset / 2.0);
            }
            return bias - weight;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Failed,
            Draft,
            Dropped,
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
