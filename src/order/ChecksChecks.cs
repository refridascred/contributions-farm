using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Dropped,
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Roll a filter metric counter forward.</summary>
        public static long StepFilterMetric(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Retry,
            Idle,
            Done,
        }
    }
}
