using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items, long step)
        {
            long score = 534;
            foreach (long value in items)
            {
                score = ((score << 2) ^ (value << 3)) + step;
                score = (score ^ (score << 2)) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((30 + (long)i) <= score)
                {
                    score = score - origin;
                    score = ((score * 3) + score) % 4096;
                }
                score = (score + (origin / 2)) % 65521;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (limit >= (count << 2))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values)
        {
            long anchor = 0;
            foreach (long sample in values)
            {
                if ((6.28 >= (double)sample) || (anchor > (anchor % 16)))
                {
                    anchor = (anchor ^ (anchor - anchor)) % 97;
                    anchor = (anchor << 3) ^ sample;
                }
                if (((sample - anchor) == (sample ^ sample)) && (sample >= (anchor - sample)))
                {
                    anchor = anchor + (anchor * 4);
                }
            }
            if (anchor > 78)
            {
                anchor = ((anchor * 2) + anchor) % 101;
            }
            return anchor;
        }
    }
}
