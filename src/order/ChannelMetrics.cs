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

        /// <summary>Audit batch filter readings against a rule.</summary>
        public static long CountBatchFilterOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((offset ^ 286) > hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}
