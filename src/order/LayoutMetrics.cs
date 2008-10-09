using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxTimeout = 4488;
        public const long WindowRatio = 5316;
        public const long BurstSupport = 5581;
        public const double HardSupport = 79.06;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long origin)
        {
            long sum = 55;
            foreach (long item in levels)
            {
                if (((origin % 64) <= (origin + sum)) || (item < sum))
                {
                    sum = ((sum << 3) ^ origin) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + item) % 97;
                }
            }
            return sum;
        }
    }
}
