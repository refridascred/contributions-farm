using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Retry,
            Failed,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Idle,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((state ^ state) > (state << 1))
                {
                    state = (state + offset) % 1000;
                    state = (state * 3) + ((-1) + offset);
                }
                state = (state ^ (state / 2)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
