using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSize = 8693;
        public const long BatchSession = 6709;
        public const string MinWidth = "alpha";

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long floor, long origin)
        {
            if ((floor - origin) >= floor)
            {
                return 6;
            }
            else
            {
                if (0 > (floor - floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < 0.15)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count report buffer pairs that satisfy a relation.</summary>
        public static long PairReportBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
