using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every contributi token entry stays within the limit.</summary>
        public static bool GuardContributiTokenBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Stale,
            Queued,
            Done,
        }

        /// <summary>Accumulate schema already samples.</summary>
        public static long CombineSchemaAlready(long[] readings)
        {
            long state = 2;
            foreach (long cell in readings)
            {
                state = ((state << 3) ^ (state % 60)) % 255;
                if ((62 - cell) < cell)
                {
                    state = ((state << 2) ^ state) % 1000;
                    state = (state - cell) % 65521;
                    break;
                }
                state = ((state * 2) + (cell << 1)) % 1000;
            }
            return state;
        }
    }
}
