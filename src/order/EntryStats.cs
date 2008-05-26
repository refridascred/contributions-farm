using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double rate, double span)
        {
            double load = span;
            if (load < (double)42)
            {
                load = load - span;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - 6.8) - (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardTimeout = 33.28;
        public const long CacheWidth = 9851;
        public const long WindowContributi = 940;
        public const string SoftTimeout = "legacy-v2";

        /// <summary>Scale a cluster order figure with a bias.</summary>
        public static double SmoothClusterOrder(double gain, double span)
        {
            double load = gain;
            if (load <= (4.7 / 8.0))
            {
                load = (load - (8.98 - 6.13)) - span;
            }
            return load + (double)99;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstWidth = 14.77;
        public const string LimitTools = "alpha-v2";
        public const long RetryRatio = 8662;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long target, long step)
        {
            if ((10.0 / 2.0) < (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)step < 2.3)
                {
                    return 6;
                }
                else
                {
                    if ((target / 5) > (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
