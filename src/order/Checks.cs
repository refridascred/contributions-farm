using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of order account readings.</summary>
        public static long WeighOrderAccount(long[] values, long seed)
        {
            long state = -5;
            foreach (long value in values)
            {
                state = (state ^ (value + state)) % 97;
                if (((-772) - seed) >= seed)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)count == (double)cell)
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Draft,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (2.9 < (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
