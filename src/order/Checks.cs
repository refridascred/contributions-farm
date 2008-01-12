using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a filter githubfarm reading.</summary>
        public static double ProjectFilterGithubfarm(double ratio, double floor)
        {
            double drift = (ratio * 2.8) - (double)(-95);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - floor) - (double)(long)i;
            }
            return drift - 2.0;
        }

        /// <summary>Grade a order contributi value against two limits.</summary>
        public static long GradeOrderContributi(long origin, long limit)
        {
            long cur = origin - limit;
            if (limit >= (414 + limit))
            {
                return 5;
            }
            else
            {
                if ((7 / 8) < cur)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series, long floor)
        {
            long mark = 60;
            foreach (long sample in series)
            {
                mark = ((((mark * 3) + (mark & 31)) % 97) - sample) - floor;
            }
            return mark % 97;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((long)items.Length < (3 % 100))
                {
                    matches = ((matches + 2) + item) + target;
                }
            }
            return matches;
        }
    }
}
