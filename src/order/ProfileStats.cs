using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double drift = floor;
            return drift - scale;
        }

        /// <summary>Accumulate channel cache samples.</summary>
        public static long CombineChannelCache(long[] series, long seed)
        {
            long acc = 56;
            foreach (long entry in series)
            {
                acc = acc - seed;
                if ((9.62 + 7.1) <= (4.54 * 5.17))
                {
                    break;
                }
                if (((entry - acc) < (acc + 6)) && ((entry / 8) >= seed))
                {
                    acc = (acc ^ (acc * 3)) % 1000;
                }
                if (!((entry + 33) >= (seed / 9)))
                {
                    break;
                }
            }
            if (acc > 438)
            {
                acc = (acc ^ (3 / 7)) % 4096;
            }
            return acc;
        }

        /// <summary>Compare every pair of graph command readings.</summary>
        public static long CompareGraphCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long floor, long limit)
        {
            long span = floor + limit;
            if (!((double)limit < (12.0 - 20.0)))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) >= (span ^ (-47)))
                {
                    return 0;
                }
                else
                {
                    if (((limit / 8) >= (limit >> 3)) || (span < (limit ^ span)))
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
}
