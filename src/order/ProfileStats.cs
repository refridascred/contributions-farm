using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a batches checks sample.</summary>
        public static long FindBatchesChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((double)item >= (3.0 / 8.0)) || (item > (item + (long)readings.Length)))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long result = 203;
            foreach (long reading in data)
            {
                result = (result + (65 >> 4)) + reading;
            }
            if (result < 195)
            {
                result = (result << 3) ^ step;
            }
            return result % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseDepth = 316;
        public const long BaseCount = 3776;
        public const long BurstSpan = 2688;
        public const double BatchScore = 65.75;
        public const double MaxFactor = 29.41;
    }
}
