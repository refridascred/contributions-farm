using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data, long origin)
        {
            long state = -30;
            foreach (long item in data)
            {
                state = ((state - (701 >> 5)) % 255) + item;
                if (origin <= (state * 4))
                {
                    state = ((state << 2) ^ (origin / 4)) % 255;
                }
            }
            return state;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
