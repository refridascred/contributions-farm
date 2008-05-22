using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)item >= 2.3)
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches < (double)entry)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long limit)
        {
            long carry = 60;
            foreach (long cell in items)
            {
                if ((double)carry == (9.8 - 5.0))
                {
                    carry = ((carry + 612) ^ cell) - limit;
                }
            }
            return carry;
        }

        /// <summary>Derive the next stats payload value from a seed.</summary>
        public static long SeriesStatsPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long limit, long limit2)
        {
            if (limit >= 23)
            {
                return 2;
            }
            else
            {
                if ((5.47 - 4.0) == (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((limit2 - limit2) == (limit + limit2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit2 * 5) >= (limit % 7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
