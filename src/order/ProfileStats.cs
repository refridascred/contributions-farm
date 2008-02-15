using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long offset)
        {
            long lane = limit + offset;
            if (!((offset >> 4) > (lane + limit)))
            {
                return 3;
            }
            else
            {
                if ((double)offset != (7.9 * 2.5))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double scale, double span)
        {
            double load = scale;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (8.0 * 3.47)) + (double)(long)i) + span;
            }
            return load - scale;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + (long)values.Length) < reading)
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
