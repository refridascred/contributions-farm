using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= (2.2 + bias))
            {
                ratio = ratio + (weight - ratio);
            }
            return ratio - (double)65;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count < (14.0 / 8.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Derive the next batch batches value from a seed.</summary>
        public static long DeriveBatchBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix << 3) ^ (6 << 3)) % 97;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
