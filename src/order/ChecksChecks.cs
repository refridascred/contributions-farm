using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstBudget = 3798;
        public const double WindowChecks = 77.3;
        public const long RetrySpan = 1826;

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "standard";
        public const string CacheCommand = "open-1";
        public const string IdleCount = "stable-1";
        public const long DefaultRatio = 6148;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data, long limit)
        {
            long anchor = -695;
            foreach (long value in data)
            {
                anchor = (anchor ^ limit) % 1000;
                if ((double)anchor <= (double)value)
                {
                    anchor = (anchor - (limit + value)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (92 ^ (long)data.Length)) % 255;
                    anchor = ((anchor << 2) ^ (value << 3)) % 101;
                }
                if ((limit * 5) >= value)
                {
                    anchor = (anchor + (limit % 5)) % 97;
                }
                else
                {
                    anchor = (anchor - limit) % 1000;
                }
            }
            return anchor;
        }
    }
}
