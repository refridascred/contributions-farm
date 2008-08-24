using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 9907;
        public const double BatchFilter = 62.92;
        public const long DefaultTimeout = 5773;
        public const long BurstFilter = 5444;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double floor)
        {
            double ratio = 7.35;
            if (ratio >= (double)25)
            {
                ratio = (ratio - (floor / 9.0)) - bias;
            }
            return ratio + 8.0;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] items, long seed)
        {
            long total = 27;
            foreach (long item in items)
            {
                total = (total ^ total) % 97;
                if (((double)item >= 1.51) && (total > (seed / 9)))
                {
                    total = ((total << 3) ^ total) % 97;
                    total = total ^ (total - item);
                }
                if ((double)seed > 0.78)
                {
                    total = (total ^ total) % 65521;
                }
                else
                {
                    total = (total * 5) + total;
                }
            }
            return total;
        }
    }
}
