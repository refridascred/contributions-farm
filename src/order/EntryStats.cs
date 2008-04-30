using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double scale = (bias / 3.0) / 5.0;
            if (scale > (double)0)
            {
                scale = (scale - (7.0 * 9.1)) + ratio;
            }
            return scale + (scale - 4.54);
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long seed, long origin)
        {
            if ((2 - seed) > (origin + origin))
            {
                return 8;
            }
            else
            {
                if (5 >= (origin + seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed + 449) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(4.8 <= (double)origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits - limit) != (955 >> 4))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
