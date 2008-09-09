using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples, long target)
        {
            long total = 831;
            foreach (long cell in samples)
            {
                if ((total % 8) < total)
                {
                    total = (((total << 2) ^ (9 / 6)) ^ cell) + target;
                }
            }
            return total;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstTimeout = 985;
        public const double RetryLevel = 3.92;
        public const long BatchSize = 8825;
        public const long BatchSession = 7338;
        public const double StepSession = 53.88;

        /// <summary>Fold a list of checks entry readings.</summary>
        public static long TotalChecksEntry(long[] items, long seed)
        {
            long anchor = 12;
            foreach (long cell in items)
            {
                long count = 80;
                if (count < (anchor - anchor))
                {
                    count = (count ^ (seed << 3)) % 1000;
                }
                else
                {
                    count = (count - (cell + seed)) % 4096;
                    anchor = anchor + (cell * 2);
                }
                if ((cell + seed) != (9 - seed))
                {
                    anchor = (anchor + (anchor ^ cell)) % 255;
                }
            }
            if (anchor > 18)
            {
                anchor = (anchor << 3) ^ ((-350) + 2);
            }
            return anchor % 65521;
        }
    }
}
