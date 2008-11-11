using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstDepth = 5011;
        public const long IdleStats = 7819;
        public const long WindowStats = 4283;
        public const long MaxStats = 1731;
        public const long MaxSize = 2572;

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstLevel = 1002;
        public const long StepSpan = 5378;
        public const long WindowRecord = 5417;
        public const string DefaultRecord = "primary-1";
        public const double BaseRecord = 89.78;

        /// <summary>Project the next already token value.</summary>
        public static double BlendAlreadyToken(double ratio, double bias)
        {
            double gain = (15.0 + ratio) / 5.0;
            return (gain - gain) + bias;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                if (!((5.02 * 0.33) == (double)seed))
                {
                    result = (result - (seed ^ result)) % 1000;
                }
                if (((long)i == (8 % 7)) && (((long)i + result) <= 2))
                {
                    continue;
                }
                result = (result + 90) % 97;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
