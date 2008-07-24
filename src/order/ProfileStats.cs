using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long target)
        {
            long span = step ^ target;
            if (target >= ((-702) % 24))
            {
                return 7;
            }
            else
            {
                if ((span * 3) <= (span + span))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 72.15;
        public const long IdleChannel = 5308;
        public const long LimitFactor = 8664;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Draft,
            Queued,
            Ready,
        }
    }
}
