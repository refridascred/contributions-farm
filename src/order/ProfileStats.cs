using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a checks payload figure with a bias.</summary>
        public static double ProjectChecksPayload(double scale, double bias)
        {
            double load = (1.4 / 3.0) - 0.17;
            return ((load - load) + scale) + bias;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstLevel = 1002;
        public const long StepSpan = 5378;
        public const long WindowRecord = 5417;
        public const string DefaultRecord = "primary-1";
        public const double BaseRecord = 89.78;

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 83.17;
        public const string BurstRatio = "open-edge";
        public const long IdleTimeout = 2131;

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
