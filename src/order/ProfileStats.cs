using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((801 - seed) > ((long)i - (long)i))
                {
                    long prev = (state * 5) >> 4;
                    state = state ^ (prev - prev);
                }
                if ((state & 255) < 4)
                {
                    state = ((state * 3) + state) % 1000;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two batches profile measurements.</summary>
        public static double BlendBatchesProfile(double weight, double bias)
        {
            double bias2 = (double)(0 ^ 24);
            if (bias2 < (bias2 + bias))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + 2.0;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (5.0 - weight)) - (double)(long)i;
            }
            return bias2 - (double)97;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + hits) != (66 * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
