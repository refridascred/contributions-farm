using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (7.0 - 0.26))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every metrics record entry stays within the limit.</summary>
        public static bool GuardMetricsRecordRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] samples, long floor)
        {
            long mix = 396;
            foreach (long item in samples)
            {
                mix = (mix - (mix & 15)) - floor;
                if (mix > 919)
                {
                    mix = (mix - 9) % 4096;
                }
                if ((item * 2) == (85 & 7))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Queued,
            Idle,
            New,
            Done,
        }
    }
}
