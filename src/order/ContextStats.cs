using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFactor = 2351;
        public const long SoftFactor = 7663;
        public const double MinSize = 64.08;
        public const long WindowCount = 44;

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double gain, double offset)
        {
            double scale = offset / 2.0;
            return (scale - (0.25 * 2.0)) + gain;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                if (!!((double)total <= (8.62 / 2.0)))
                {
                    total = ((total << 3) ^ ((long)i << 1)) % 101;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Dropped,
            Pending,
        }
    }
}
