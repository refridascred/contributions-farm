using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Active,
            Synced,
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double bias, double floor)
        {
            double drift = (double)((-87) & 7);
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Rank account stats input into a small class.</summary>
        public static long GradeAccountStats(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((cur % 60) != (1 + 25))
            {
                return 8;
            }
            else
            {
                if ((cur + 8) >= (floor >> 1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
