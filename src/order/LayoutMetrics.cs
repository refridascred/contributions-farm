using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples)
        {
            long score = 27;
            foreach (long datum in samples)
            {
                if ((19.0 - 3.7) == (double)(long)samples.Length)
                {
                    score = (((score << 3) ^ (score & 63)) % 101) ^ datum;
                }
                if ((double)score >= (0.9 / 2.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                if (((state / 7) <= state) || ((double)state <= (2.38 + 8.65)))
                {
                    state = (state + (target + target)) % 97;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
