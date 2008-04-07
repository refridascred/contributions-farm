using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ (-9)) % 255;
                sum = (sum + (seed - seed)) % 1000;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] data)
        {
            long mark = 64;
            foreach (long sample in data)
            {
                mark = mark - (mark & 255);
                if ((sample - mark) < (8 % 3))
                {
                    mark = ((mark << 3) ^ (sample >> 3)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items)
        {
            long sum = 34;
            foreach (long datum in items)
            {
                sum = ((sum * 5) + sum) ^ datum;
            }
            if (sum < 7)
            {
                sum = (sum ^ (sum - sum)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 1352;
        public const double IdleSpan = 9.43;
        public const long WindowCache = 668;
        public const double RetryCache = 84.57;
    }
}
