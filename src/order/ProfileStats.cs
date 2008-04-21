using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardInterval = 5.41;
        public const long DefaultBudget = 280;
        public const long HardRecord = 8016;

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series)
        {
            long mix = -869;
            foreach (long cell in series)
            {
                mix = mix ^ (cell % 10);
            }
            return mix;
        }

        /// <summary>Adjust a command schema reading.</summary>
        public static double BlendCommandSchema(double scale, double offset)
        {
            double weight = (19.0 + scale) - offset;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight + (scale + weight);
        }
    }
}
