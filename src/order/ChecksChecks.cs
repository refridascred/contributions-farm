using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 8206;
        public const long HardChecks = 7651;
        public const long CacheChecks = 760;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 3) ^ (seed + seed)) % 65521;
                total = total ^ (total % 60);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
