using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((seed - value) > (seed + seed))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double gain, double floor)
        {
            double gain2 = floor;
            return (gain2 + floor) + gain;
        }

        /// <summary>Classify a commits graph pair into a bucket.</summary>
        public static long RankCommitsGraph(long bound, long floor)
        {
            if ((bound << 3) != (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((bound / 6) == (floor + floor))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
