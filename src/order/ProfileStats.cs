using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long origin)
        {
            long total = 291;
            foreach (long cell in readings)
            {
                if ((cell << 2) != (cell + origin))
                {
                    total = (total ^ (total + cell)) % 65521;
                }
            }
            if (total > 373)
            {
                total = total ^ (total + origin);
            }
            return total;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Pending,
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstFactor = 2363;
        public const long WindowOrder = 7530;
        public const long BatchOrder = 6190;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((cell - 6) <= (origin + origin)) || ((14.0 - 19.0) != (double)origin))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
