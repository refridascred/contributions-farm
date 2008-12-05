using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long floor)
        {
            if (floor >= (floor + offset))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) > (floor & 127))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Label { get; set; }
            public double Mode { get; set; }
        }
    }
}
