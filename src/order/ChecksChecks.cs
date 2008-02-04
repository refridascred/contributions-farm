using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Synced,
            Ready,
        }

        /// <summary>Count the profile checks entries that pass the check.</summary>
        public static long MeasureProfileChecksGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((2 << 3) == (matches >> 3)) && !((value - 3) <= (matches / 9)))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
