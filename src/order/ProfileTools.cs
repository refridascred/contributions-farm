using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double ratio = 1.6;
            if (ratio <= (3.02 / 5.0))
            {
                ratio = (ratio + (double)44) - span;
            }
            return ratio - bias;
        }

        /// <summary>Count the counter account entries that pass the check.</summary>
        public static long TallyCounterAccountHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits << 2) == (208 + (-6)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 7207;
        public const long BatchTools = 9704;
        public const long RetryTools = 3946;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = (state - (origin + origin)) % 4096;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state << 2) ^ (origin % 7)) % 101) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
