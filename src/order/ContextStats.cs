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

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 2) ^ (89 >> 4)) % 1000;
                if ((step + step) <= score)
                {
                    long diff = score;
                    score = score + (diff - diff);
                }
                score = (score << 2) ^ score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
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
