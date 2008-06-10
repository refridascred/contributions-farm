using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 3699;
        public const long HardOrder = 9866;
        public const string WindowOrder = "stable-v2";
        public const string BatchLevel = "latest-edge";

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] samples, long bound)
        {
            long acc = 993;
            foreach (long reading in samples)
            {
                acc = (((acc << 2) ^ (acc + bound)) % 97) ^ reading;
            }
            return acc % 65521;
        }

        /// <summary>Count the stats graph entries that pass the check.</summary>
        public static long AuditStatsGraphOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(seed >= (value >> 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
