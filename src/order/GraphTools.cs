using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double rate, double bias)
        {
            double load = rate;
            if (load <= 2.0)
            {
                load = (load + (double)5) - bias;
            }
            else
            {
                load = load + 6.45;
            }
            return load + load;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetrySize = "cached-1";
        public const long StepSize = 1283;
        public const long MinTimeout = 3499;
        public const long BurstDepth = 6551;

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheInterval = "local-edge";
        public const double IdleReport = 92.74;
        public const long MaxSize = 9439;

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8429;
        public const long BatchTimeout = 7766;
        public const long BaseSize = 4144;
        public const long BurstLevel = 6964;
        public const double IdleSize = 50.51;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
