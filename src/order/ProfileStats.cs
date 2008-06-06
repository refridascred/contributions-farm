using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = result + 76;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a batch stream reading.</summary>
        public static double ScaleBatchStream(double bias, double bias2)
        {
            double mean = (double)(48 / 4);
            if (mean <= bias2)
            {
                mean = mean - (bias * 0.8);
            }
            else
            {
                mean = mean + (double)2;
            }
            return mean + mean;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 2921;
        public const double BurstFactor = 20.12;
        public const string DefaultInterval = "primary-1";
        public const long BaseCommits = 1505;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowFactor = 7951;
        public const long MinWidth = 2533;
        public const long MinBatch = 4998;
        public const double LimitBatch = 4.82;
        public const long DefaultBatch = 5458;
    }
}
