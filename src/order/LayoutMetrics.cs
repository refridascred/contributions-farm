using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            New,
            Active,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((step & 3) <= (matches % 8))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Find the first farm window entry that matches the target.</summary>
        public static long LookupFarmWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
