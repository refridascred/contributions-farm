using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many record payload samples are out of range.</summary>
        public static long MeasureRecordPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum - count) < datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 8688;
        public const long BurstDepth = 2312;
        public const string RetryFilter = "latest-1";
        public const long DefaultTimeout = 1330;
        public const long MaxFilter = 8290;
    }
}
