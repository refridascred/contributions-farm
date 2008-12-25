using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MinWidth = 84.18;
        public const double BurstSize = 25.66;
        public const long BurstFarm = 4302;

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double gain, double span)
        {
            double mean = (double)(8 + 3);
            return ((mean + mean) + gain) + span;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)seed == (0.01 - 9.56))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Paused,
            Draft,
            Locked,
            Failed,
        }
    }
}
