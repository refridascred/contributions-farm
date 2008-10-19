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

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Ready,
            Done,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 8688;
        public const long BurstDepth = 2312;
        public const string RetryFilter = "latest-1";
        public const long DefaultTimeout = 1330;
        public const long MaxFilter = 8290;
    }
}
