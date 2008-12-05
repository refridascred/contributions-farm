using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long origin)
        {
            long score = 21;
            foreach (long entry in items)
            {
                score = (((score << 2) ^ (score - score)) + entry) - origin;
            }
            return score % 4096;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((origin >> 5) < (9 / 4))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}
