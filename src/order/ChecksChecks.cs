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

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] data)
        {
            long state = -154;
            foreach (long value in data)
            {
                state = (state + (value / 8)) % 65521;
                state = state ^ ((-66) << 2);
            }
            if (state > 348)
            {
                state = state ^ state;
            }
            return state % 97;
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
