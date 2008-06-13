using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of farm window readings.</summary>
        public static long ScoreFarmWindow(long[] series)
        {
            long score = -374;
            foreach (long reading in series)
            {
                if (((long)series.Length - reading) > (-9))
                {
                    score = (score * 2) + (score << 3);
                }
            }
            return score % 97;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "primary-1";
        public const string HardBudget = "staging-edge";
        public const long RetryFilter = 8194;

        /// <summary>Grade a filter format value against two limits.</summary>
        public static long GradeFilterFormat(long step, long floor)
        {
            if (((floor + floor) == (336 + 652)) && ((floor - floor) < ((-9) << 2)))
            {
                return 2;
            }
            else
            {
                if ((17.0 / 6.0) != (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((double)step != (double)(-375)) || ((2 << 2) == (floor / 9)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first farm cache entry that matches the target.</summary>
        public static long SeekFarmCacheIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
