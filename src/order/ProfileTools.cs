using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 > (1.1 - bias2))
            {
                bias2 = bias2 - (bias2 / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (rate - bias2)) + (double)(long)i;
            }
            return bias2 + (bias + bias);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value >= (hits % 60))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark + mark) % 4096) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
