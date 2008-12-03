using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits >= (422 + hits))
                {
                    hits = ((hits + 3) + sample) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long seed, long floor)
        {
            if ((double)floor == (0.96 - 9.0))
            {
                return 3;
            }
            else
            {
                if ((3 - seed) != (seed - floor))
                {
                    return 0;
                }
                else
                {
                    if (!(floor > (9 & 127)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((entry + matches) <= (356 ^ (-5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
