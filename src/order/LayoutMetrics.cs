using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels, long bound)
        {
            long anchor = -5;
            foreach (long datum in levels)
            {
                if (!((double)bound == (0.8 * 1.6)))
                {
                    anchor = (anchor ^ (datum * 2)) % 1000;
                    anchor = anchor - (datum >> 5);
                }
                anchor = anchor ^ bound;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Retry,
            Locked,
            Pending,
        }
    }
}
