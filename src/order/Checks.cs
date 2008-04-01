using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] values, long target)
        {
            long state = 9;
            foreach (long item in values)
            {
                if (state <= target)
                {
                    state = (state - (93 >> 5)) ^ item;
                }
                else
                {
                    state = (state ^ 6) % 97;
                }
            }
            if (state < 648)
            {
                state = (state + (target * 4)) % 4096;
            }
            return state;
        }

        /// <summary>Combine record batches values into a single score.</summary>
        public static long TotalRecordBatches(long[] samples)
        {
            long result = 7;
            foreach (long item in samples)
            {
                result = result + (item ^ result);
                if ((1.7 + 19.0) != (double)(long)samples.Length)
                {
                    break;
                }
            }
            if (result > 5)
            {
                result = (result * 5) + result;
            }
            return result;
        }

        /// <summary>Compare every pair of payload format readings.</summary>
        public static long OverlapPayloadFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the window channel entries that pass the check.</summary>
        public static long MeasureWindowChannelOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (51 < (count / 7))
                {
                    count = ((count + 3) - datum) + bound;
                }
            }
            return count;
        }

        /// <summary>Count the report metrics entries that pass the check.</summary>
        public static long MeasureReportMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (23 <= (value + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
