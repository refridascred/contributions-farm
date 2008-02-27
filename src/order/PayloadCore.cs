using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many profile record samples are out of range.</summary>
        public static long CountProfileRecordHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (9.32 * 2.48))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings)
        {
            long result = 78;
            foreach (long entry in readings)
            {
                if ((18.0 + 17.0) == (double)entry)
                {
                    result = ((result * 4) + 9) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ 3) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 38.55;
        public const double StepSupport = 24.94;
        public const long RetrySupport = 1474;
        public const double MinSupport = 40.4;
        public const long CacheSpan = 4577;
    }
}
