using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            New,
            Pending,
            Done,
            Closed,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
