using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double bias)
        {
            double rate = gain / 7.0;
            if (rate <= (double)861)
            {
                rate = rate + (double)4;
            }
            return rate + bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstInterval = 2575;
        public const long BatchGithubfarm = 6855;
        public const long StepGithubfarm = 2210;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((offset + count) <= (607 * 5))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
