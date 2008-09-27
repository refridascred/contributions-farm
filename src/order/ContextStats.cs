using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long floor, long floor2)
        {
            if ((floor + floor2) < (floor / 6))
            {
                return 0;
            }
            else
            {
                if (!(floor <= (floor2 >> 5)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine notes token values into a single score.</summary>
        public static long FoldNotesToken(long[] readings, long step)
        {
            long score = 6;
            foreach (long sample in readings)
            {
                score = (score * 4) + (sample + step);
                if ((62 & 15) >= sample)
                {
                    score = (score << 2) ^ (sample % 100);
                }
            }
            if (score < 899)
            {
                score = (score * 3) + step;
            }
            return score % 1000;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long step, long bound)
        {
            long delta = step ^ bound;
            if ((4.1 + 6.0) > (double)delta)
            {
                return 5;
            }
            else
            {
                if ((double)step <= (9.1 - 6.65))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
