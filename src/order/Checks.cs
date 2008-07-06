using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((9.69 + 3.1) > (double)(long)values.Length)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Measure how many order entry samples are out of range.</summary>
        public static long CountOrderEntryOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits << 1) >= 58)
                {
                    hits = ((hits + 3) + reading) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((0.49 * 6.17) != (double)reading) && ((double)reading <= (10.0 / 6.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format batches samples.</summary>
        public static long CombineFormatBatches(long[] series, long offset)
        {
            long sum = -1;
            foreach (long entry in series)
            {
                sum = (sum ^ (0 + entry)) % 4096;
            }
            if (sum > 71)
            {
                sum = (sum + (offset << 2)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
