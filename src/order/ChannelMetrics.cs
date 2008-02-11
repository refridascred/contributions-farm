using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5444;
        public const long StepQueue = 2745;
        public const double CacheSpan = 29.81;
        public const double CacheQueue = 33.05;

        /// <summary>Compare every pair of contributi metric readings.</summary>
        public static long MatchContributiMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long step)
        {
            long span = floor ^ step;
            if ((double)step != (5.88 + 2.41))
            {
                return 4;
            }
            else
            {
                if ((floor ^ span) <= (floor * 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
