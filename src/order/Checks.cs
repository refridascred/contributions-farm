using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Retry,
            Stale,
            New,
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

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!!((double)(long)i >= (1.72 - 1.2)))
                {
                    mark = ((mark << 2) ^ (215 & 127)) % 4096;
                }
                long hits = -1;
                if (((seed % 60) <= (mark ^ hits)) || (17.0 > (double)(long)i))
                {
                    hits = hits + (seed >> 3);
                }
                else
                {
                    mark = (mark - (seed + seed)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
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
