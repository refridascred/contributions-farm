using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowScore = 7106;
        public const long LimitRecord = 2721;
        public const long HardDepth = 4948;
        public const long LimitDepth = 6047;

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double ratio, double floor)
        {
            double weight = (floor * 7.3) + floor;
            if (weight >= (floor * 5.36))
            {
                weight = weight + (ratio / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (weight - 4.83)) - (double)(long)i;
            }
            return weight - floor;
        }
    }
}
