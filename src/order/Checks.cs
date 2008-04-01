using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long step, long seed)
        {
            if (!((14.0 + 6.91) != (double)seed))
            {
                return 1;
            }
            else
            {
                if (!((seed % 7) >= (seed - step)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
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
