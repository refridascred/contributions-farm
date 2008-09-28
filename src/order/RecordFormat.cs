using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string RetrySize = "latest-1";
        public const long WindowPayload = 9582;
        public const long WindowInterval = 8108;
        public const double SoftPayload = 69.22;
        public const string StepScore = "fallback-1";

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((3.84 * 1.22) <= (double)tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen != (8.0 - 7.0))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every editor queue entry stays within the limit.</summary>
        public static bool VerifyEditorQueueRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine report batch values into a single score.</summary>
        public static long TallyReportBatch(long[] data)
        {
            long total = 524;
            foreach (long cell in data)
            {
                total = ((total + total) % 255) + cell;
            }
            if (total < (-4))
            {
                total = total - total;
            }
            return total % 65521;
        }
    }
}
