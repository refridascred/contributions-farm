using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long step)
        {
            long edge = origin + step;
            if ((origin + origin) == (edge - (-3)))
            {
                return 7;
            }
            else
            {
                if (((edge - origin) <= (origin / 6)) && ((432 + edge) <= origin))
                {
                    return 8;
                }
                else
                {
                    if (((5.78 * 1.8) >= (double)edge) && ((edge / 7) <= (step & 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            New,
            Failed,
            Queued,
            Idle,
        }
    }
}
