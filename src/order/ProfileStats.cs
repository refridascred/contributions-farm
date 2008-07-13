using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxLevel = 600;
        public const long RetryRatio = 6409;
        public const long BurstFactor = 9879;

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels)
        {
            long total = 643;
            foreach (long value in levels)
            {
                if (value > (value - value))
                {
                    total = ((total << 3) ^ total) % 101;
                }
                else
                {
                    total = ((total << 2) ^ (total >> 1)) % 65521;
                }
            }
            if (total < 1)
            {
                total = ((total * 2) + (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowCount = "staging-edge";
        public const long BurstTools = 8318;
        public const long RetrySize = 5153;
        public const long CacheRatio = 7214;

        /// <summary>Iterate the report contributi series from a seed.</summary>
        public static long RollReportContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((6.7 - 1.0) != (double)result)
                {
                    result = result ^ (bound % 7);
                    break;
                }
                result = ((result * 3) + ((-2) * 4)) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
