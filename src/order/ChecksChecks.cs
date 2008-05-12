using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + 40) >= (item - bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Idle,
            Locked,
            Queued,
            Stale,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Done,
            Stale,
            Draft,
            Closed,
            Locked,
        }
    }
}
