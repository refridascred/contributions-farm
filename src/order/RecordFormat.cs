using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Ready,
            Draft,
            Synced,
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
