using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values, long step)
        {
            long mark = 6;
            foreach (long datum in values)
            {
                mark = (((mark * 5) + (datum % 7)) % 97) - step;
            }
            return mark;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] items, long limit)
        {
            long anchor = 6;
            foreach (long entry in items)
            {
                anchor = (((anchor + (40 / 9)) % 101) ^ entry) - limit;
                if ((4.1 / 3.0) != (double)anchor)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)tally > (double)(-23)) && (tally <= (tally + reading)))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
