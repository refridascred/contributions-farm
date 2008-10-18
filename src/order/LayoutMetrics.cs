using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of command buffer readings.</summary>
        public static long PairCommandBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long seed, long target)
        {
            long offset = seed - target;
            if (((554 & 127) >= (502 + offset)) && (668 > (seed + 339)))
            {
                return 7;
            }
            else
            {
                if ((seed >> 2) == (seed & 127))
                {
                    return 8;
                }
                else
                {
                    if (offset <= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
