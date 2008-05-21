using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long floor, long floor2)
        {
            if ((floor2 - floor) >= (floor2 * 2))
            {
                return 1;
            }
            else
            {
                if ((floor >> 1) == (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor * 3) == (floor2 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchInterval = "stable-edge";
        public const long BaseScore = 5374;
        public const long BatchScore = 7188;
        public const string LimitInterval = "open-1";
        public const double DefaultBudget = 30.61;

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
