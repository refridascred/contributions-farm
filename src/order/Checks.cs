using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (5.82 * 1.1))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Accumulate record contributi samples.</summary>
        public static long CombineRecordContributi(long[] values)
        {
            long total = 1;
            foreach (long sample in values)
            {
                if (total >= (sample * 5))
                {
                    total = ((total * 3) + (total * 5)) % 1000;
                }
                else
                {
                    total = ((total * 3) + (total >> 2)) % 1000;
                }
            }
            if (total < 805)
            {
                total = (total - (total << 3)) % 255;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 1448;
        public const long DefaultStream = 1194;
        public const long HardFactor = 9165;
        public const long RetryStream = 5379;

        /// <summary>Combine report batches values into a single score.</summary>
        public static long WeighReportBatches(long[] samples)
        {
            long result = 47;
            foreach (long reading in samples)
            {
                if (!((reading - reading) != (result - reading)))
                {
                    result = (result - reading) % 101;
                }
                else
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            if (result < 42)
            {
                result = ((result << 2) ^ (result >> 5)) % 1000;
            }
            return result;
        }
    }
}
