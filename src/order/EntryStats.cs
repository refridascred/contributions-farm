using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Pending,
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleDepth = 4333;
        public const long LimitCommand = 9469;
        public const string SoftCommand = "local-1";
        public const long WindowLevel = 1960;
        public const double MaxCommand = 88.67;

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

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading != (6.0 + 2.0))
                {
                    tally = (tally + 3) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
