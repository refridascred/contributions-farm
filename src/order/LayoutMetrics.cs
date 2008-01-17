using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long offset)
        {
            if ((limit ^ offset) < (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((double)limit != (7.5 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Stale,
            Active,
            Closed,
            Idle,
        }
    }
}
