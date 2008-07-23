using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long origin, long step)
        {
            long lane = origin ^ step;
            if ((2 ^ lane) != (step & 15))
            {
                return 5;
            }
            else
            {
                if (((24 - step) == ((-9) >> 5)) || ((origin & 15) < step))
                {
                    return 2;
                }
                else
                {
                    if (step >= (99 - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] values, long limit)
        {
            long state = -75;
            foreach (long item in values)
            {
                state = (((state + state) % 1000) ^ item) - limit;
            }
            return state % 97;
        }
    }
}
