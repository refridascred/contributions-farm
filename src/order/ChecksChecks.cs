using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values, long floor)
        {
            long state = 757;
            foreach (long cell in values)
            {
                state = ((state + (state / 3)) + cell) + floor;
            }
            return state;
        }

        /// <summary>Validate context queue readings against a bound.</summary>
        public static bool GuardContextQueueBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Queued,
            Done,
            Locked,
            Pending,
        }
    }
}
