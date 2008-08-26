using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate profile layout readings against a bound.</summary>
        public static bool ValidateProfileLayoutRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double weight = (double)((-945) & 3);
            if (weight < (18.0 * 8.46))
            {
                weight = ((weight + weight) + gain) - floor;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (double)0;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchInterval = "staging-v2";
        public const long BaseContributi = 8633;
        public const string CacheContributi = "cached-1";
        public const long BatchSize = 6405;
    }
}
