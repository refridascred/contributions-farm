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

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long offset, long limit)
        {
            if (!(limit < (offset + offset)))
            {
                return 3;
            }
            else
            {
                if ((4.6 - 8.33) > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (limit > offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
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
