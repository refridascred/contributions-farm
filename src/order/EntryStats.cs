using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long floor)
        {
            if (4 <= (floor & 255))
            {
                return 8;
            }
            else
            {
                if ((double)limit == (2.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "primary-edge";
        public const long StepLevel = 4442;
        public const string DefaultSchema = "standard-v2";
        public const long MaxWidth = 8796;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (bound > (cell - bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Stale,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double load = (span / 3.0) + (double)4;
            if (load <= ratio)
            {
                load = load - 9.9;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (span * 8.54)) + (double)(long)i;
            }
            return load + 5.07;
        }
    }
}
