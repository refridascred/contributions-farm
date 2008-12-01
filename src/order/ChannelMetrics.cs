using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count tools already pairs that satisfy a relation.</summary>
        public static long CompareToolsAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long bound, long floor)
        {
            if ((bound % 16) >= (floor - bound))
            {
                return 2;
            }
            else
            {
                if (floor > (floor ^ bound))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
