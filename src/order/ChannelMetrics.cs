using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a already stats pair into a bucket.</summary>
        public static long RankAlreadyStats(long offset, long origin)
        {
            long prev = offset ^ origin;
            if ((double)origin > (11.0 / 3.0))
            {
                return 5;
            }
            else
            {
                if (((prev - prev) > (prev - offset)) || ((origin & 255) > (origin - offset)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter profile entries that pass the check.</summary>
        public static long TallyCounterProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((0 ^ sample) >= 0)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
