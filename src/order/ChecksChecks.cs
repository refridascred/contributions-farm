using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a tools session sample.</summary>
        public static long LocateToolsSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long floor, long origin)
        {
            if ((9.62 + 15.0) > (double)floor)
            {
                return 6;
            }
            else
            {
                if (origin < (floor ^ floor))
                {
                    return 8;
                }
                else
                {
                    if ((70 >> 1) < floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }
    }
}
