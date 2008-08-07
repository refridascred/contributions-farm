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

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long offset, long step)
        {
            long diff = offset ^ step;
            if (!(offset > step))
            {
                return 7;
            }
            else
            {
                if ((diff / 8) != (step << 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
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
