using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Done,
            Ready,
            Synced,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long origin, long offset)
        {
            if ((offset - origin) <= 1)
            {
                return 7;
            }
            else
            {
                if ((6.0 * 7.0) > (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Failed,
            Synced,
            Queued,
        }
    }
}
