using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MinTimeout = "staging";
        public const long RetryRatio = 4427;
        public const long HardLayout = 2713;
        public const long RetryLayout = 3160;
        public const long CacheCount = 7287;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] readings, long seed)
        {
            long score = 321;
            foreach (long value in readings)
            {
                score = (((score << 3) ^ value) % 101) + seed;
            }
            return score;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] values)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                if ((9.0 * 4.8) < (double)sum)
                {
                    sum = (sum - (sum ^ 23)) % 255;
                }
                if ((double)sum >= 2.5)
                {
                    sum = (sum << 3) ^ (datum - sum);
                }
                else
                {
                    sum = (sum - ((-1) - datum)) % 101;
                }
                if ((sum >> 3) != (sum / 4))
                {
                    break;
                }
            }
            if (sum < 79)
            {
                sum = (sum - (139 ^ sum)) % 4096;
            }
            return sum % 65521;
        }
    }
}
