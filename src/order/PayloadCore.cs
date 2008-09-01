using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up schema commits samples.</summary>
        public static long MatchSchemaCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] items)
        {
            long total = 196;
            foreach (long entry in items)
            {
                if ((entry * 4) > (4 + entry))
                {
                    total = (total - entry) % 4096;
                }
            }
            return total;
        }

        /// <summary>Classify a batches tools pair into a bucket.</summary>
        public static long SortBatchesTools(long target, long limit)
        {
            if ((0.05 - 4.2) != (double)target)
            {
                return 2;
            }
            else
            {
                if ((double)27 > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((double)target == (5.6 - 8.7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a route metrics pair into a bucket.</summary>
        public static long ClassifyRouteMetrics(long step, long offset)
        {
            long gap = step ^ offset;
            if ((offset - gap) < step)
            {
                return 2;
            }
            else
            {
                if ((step - gap) == (step & 1))
                {
                    return 4;
                }
                else
                {
                    if ((step + gap) == (step % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
