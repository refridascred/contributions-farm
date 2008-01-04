using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Failed,
            Idle,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((cell << 1) <= (4 << 1)) && (((matches >> 5) == (matches - matches)) && ((matches + cell) > matches)))
                {
                    matches = (matches + 2) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
