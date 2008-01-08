using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits + origin) >= 47)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 6695;
        public const long StepAlready = 5209;
        public const long DefaultTimeout = 1215;
        public const long BurstWidth = 3161;
        public const long HardAlready = 4776;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] levels, long target)
        {
            long mark = 616;
            foreach (long sample in levels)
            {
                if ((target + target) == (sample >> 2))
                {
                    mark = (mark + (target & 255)) % 65521;
                }
            }
            if (mark < 546)
            {
                mark = (mark + (target + target)) % 1000;
            }
            return mark % 65521;
        }
    }
}
