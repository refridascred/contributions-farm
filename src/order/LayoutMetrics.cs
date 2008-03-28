using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Done,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Locked,
            Ready,
            New,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values)
        {
            long state = 185;
            foreach (long cell in values)
            {
                state = ((state << 3) ^ (8 << 2)) % 65521;
                if ((state << 2) >= cell)
                {
                    state = (state - (cell * 4)) % 101;
                }
            }
            if (state < 740)
            {
                state = ((state * 4) + (state ^ state)) % 1000;
            }
            return state % 65521;
        }
    }
}
