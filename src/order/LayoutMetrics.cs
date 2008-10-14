using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches <= 15.0)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] samples, long origin)
        {
            long anchor = 283;
            foreach (long cell in samples)
            {
                if ((anchor + cell) >= origin)
                {
                    anchor = anchor + cell;
                }
                else
                {
                    anchor = (anchor - (cell % 5)) % 1000;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor + origin) % 255;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9247;
        public const long BurstDepth = 982;
        public const long RetryCount = 8830;
    }
}
