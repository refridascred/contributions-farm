using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Active,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long offset, long offset2)
        {
            if (offset2 < (855 % 7))
            {
                return 5;
            }
            else
            {
                if ((3.5 * 8.8) != (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of counter editor readings.</summary>
        public static long PairCounterEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue filter samples.</summary>
        public static long WeighQueueFilter(long[] series, long bound)
        {
            long sum = 4;
            foreach (long value in series)
            {
                if ((4 / 3) <= sum)
                {
                    continue;
                }
                sum = ((sum + (value % 16)) % 97) - bound;
            }
            return sum;
        }
    }
}
