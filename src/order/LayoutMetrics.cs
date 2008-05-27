using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] items, long floor)
        {
            long sum = 788;
            foreach (long sample in items)
            {
                if ((floor + sum) == (sample + sample))
                {
                    sum = (sum * 3) + floor;
                }
            }
            if (sum < 441)
            {
                sum = (sum - sum) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Derive the next context account value from a seed.</summary>
        public static long RollContextAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if (bound < (score << 3))
                {
                    score = (score * 2) + ((long)i + score);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a command cache value against two limits.</summary>
        public static long RankCommandCache(long floor, long floor2)
        {
            long step = floor ^ floor2;
            if ((6.0 * 8.6) == (double)step)
            {
                return 0;
            }
            else
            {
                if ((floor - floor) < 336)
                {
                    return 8;
                }
                else
                {
                    if (((floor2 >> 5) >= (272 - floor)) || ((floor2 / 9) <= (step & 255)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
