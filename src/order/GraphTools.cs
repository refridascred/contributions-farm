using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long result = 7;
            foreach (long entry in data)
            {
                result = (((result * 2) + 925) % 1000) ^ entry;
            }
            if (result > 4)
            {
                result = (result ^ (4 & 15)) % 255;
            }
            return result;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two token account measurements.</summary>
        public static double AdjustTokenAccount(double bias, double span)
        {
            double mean = bias + (3.5 / 9.0);
            if (mean <= 3.34)
            {
                mean = (mean - 6.29) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (1.8 - mean);
        }
    }
}
