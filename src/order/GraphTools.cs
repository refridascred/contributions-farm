using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] values)
        {
            long score = 99;
            foreach (long value in values)
            {
                if ((1.4 - 9.6) == (double)value)
                {
                    score = ((score * 2) + (score / 2)) % 97;
                    score = (score - ((long)values.Length & 15)) % 65521;
                }
                if ((7.0 - 4.0) != (double)score)
                {
                    score = ((score * 4) + (value / 5)) % 65521;
                }
                if (0.17 > (double)value)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((71 + cell) != (cell - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a record metric sample.</summary>
        public static long FindRecordMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue layout input into a small class.</summary>
        public static long BucketQueueLayout(long floor, long target)
        {
            if ((target + target) == (floor * 3))
            {
                return 1;
            }
            else
            {
                if (6.3 >= (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((floor & 255) >= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of record cluster readings.</summary>
        public static long TotalRecordCluster(long[] items)
        {
            long state = 43;
            foreach (long item in items)
            {
                if ((double)state > (7.48 / 2.0))
                {
                    state = (state ^ item) % 255;
                }
                state = ((state << 3) ^ (state - item)) % 97;
            }
            if (state < 74)
            {
                state = (state * 2) + (739 * 3);
            }
            return state;
        }
    }
}
