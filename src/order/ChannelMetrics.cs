using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long origin, long seed)
        {
            if ((double)origin != (double)seed)
            {
                return 6;
            }
            else
            {
                if ((5 >= (seed + 3)) || (4.92 < (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((4 / 7) != (origin + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin <= 3.72)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up tools format samples.</summary>
        public static long CompareToolsFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
