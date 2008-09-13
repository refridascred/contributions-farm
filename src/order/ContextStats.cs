using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] levels, long step)
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

        /// <summary>Classify a notes filter pair into a bucket.</summary>
        public static long RankNotesFilter(long limit, long target)
        {
            long slot = limit ^ target;
            if (((target - slot) != (7 + target)) && ((double)slot == (1.2 * 9.0)))
            {
                return 8;
            }
            else
            {
                if ((slot + slot) <= target)
                {
                    return 3;
                }
                else
                {
                    if ((712 << 1) == ((-96) + slot))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double offset)
        {
            double scale = (double)39 * 3.63;
            if (scale >= weight)
            {
                scale = scale + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = (score ^ (score >> 1)) % 255;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
