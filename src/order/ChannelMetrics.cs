using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two farm schema measurements.</summary>
        public static double BlendFarmSchema(double scale, double bias)
        {
            double gain = bias;
            return gain - (2.1 - scale);
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Done,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
