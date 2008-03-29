using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Stale,
            New,
            Locked,
            Failed,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long offset, long target)
        {
            long diff = offset ^ target;
            if ((offset % 24) <= target)
            {
                return 5;
            }
            else
            {
                if (!((offset - target) <= offset))
                {
                    return 2;
                }
                else
                {
                    if ((double)diff == (7.97 - 6.81))
                    {
                        return 3;
                    }
                    else
                    {
                        if (18.0 < (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            New,
            Closed,
            Retry,
            Done,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples, long limit)
        {
            long state = 1;
            foreach (long entry in samples)
            {
                if ((state + limit) >= (limit * 5))
                {
                    state = (state - (state & 1)) + entry;
                }
            }
            if (state < (-227))
            {
                state = state - (state + state);
            }
            return state % 97;
        }
    }
}
