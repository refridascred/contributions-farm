using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many token batches samples are out of range.</summary>
        public static long MeasureTokenBatchesOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((seed << 3) > tally) || (tally < (6 ^ seed)))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry format samples are out of range.</summary>
        public static long AuditEntryFormatOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(6.5 < (double)origin))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowDepth = 6273;
        public const long WindowTimeout = 9471;
        public const long MaxSize = 5183;

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
