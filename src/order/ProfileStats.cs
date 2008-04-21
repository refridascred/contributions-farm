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

        /// <summary>Count payload contributi pairs that satisfy a relation.</summary>
        public static long PairPayloadContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
