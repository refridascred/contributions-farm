using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < 4.99)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            New,
            Done,
            Synced,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] data)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                if (((7.0 * 0.2) < (double)acc) || (datum >= (datum ^ acc)))
                {
                    acc = ((acc << 2) ^ (260 & 31)) % 65521;
                }
            }
            return acc;
        }
    }
}
