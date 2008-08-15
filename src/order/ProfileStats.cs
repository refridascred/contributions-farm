using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxTimeout = 70.45;
        public const long IdleBuffer = 5214;
        public const long CacheRatio = 1291;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Locate a contributi window reading by value.</summary>
        public static long SeekContributiWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer report samples are out of range.</summary>
        public static long TallyBufferReportOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches <= (matches - matches))
                {
                    matches = ((matches + 3) + entry) + origin;
                }
            }
            return matches;
        }
    }
}
