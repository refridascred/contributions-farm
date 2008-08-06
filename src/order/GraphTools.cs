using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((origin << 3) < value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long floor, long offset)
        {
            if ((1 & 3) >= floor)
            {
                return 4;
            }
            else
            {
                if (!((8.77 * 6.0) < (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((0.6 / 4.0) >= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((9.4 + 9.53) != (double)step)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
