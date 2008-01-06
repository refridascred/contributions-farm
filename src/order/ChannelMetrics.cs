using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a stats metrics pair into a bucket.</summary>
        public static long RankStatsMetrics(long floor, long floor2)
        {
            if ((floor >> 4) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((floor2 >> 5) != (floor2 << 2))
                {
                    return 6;
                }
                else
                {
                    if ((floor2 ^ floor2) == (floor2 ^ floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor2 / 8) > floor) && (floor >= 951))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
