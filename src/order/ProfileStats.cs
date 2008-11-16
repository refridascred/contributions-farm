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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7601;
        public const string CacheBudget = "open";
        public const long WindowCluster = 3287;
        public const long DefaultCluster = 2404;

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
