using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BurstScore = "standard-edge";
        public const long MaxSize = 9164;
        public const long MinRoute = 6790;
        public const long SoftSpan = 1039;
        public const long StepRoute = 8821;

        /// <summary>Combine batches channel values into a single score.</summary>
        public static long CombineBatchesChannel(long[] values, long limit)
        {
            long anchor = 81;
            foreach (long datum in values)
            {
                if ((8.1 - 2.3) != (double)limit)
                {
                    anchor = ((anchor + 392) % 97) ^ datum;
                }
                else
                {
                    anchor = ((anchor * 4) + (limit >> 4)) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Check that every format record entry stays within the limit.</summary>
        public static bool ValidateFormatRecordBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item / 5) == (44 / 4))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
