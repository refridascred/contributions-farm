using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSize = "staging-1";
        public const long IdleLevel = 4129;
        public const string HardLevel = "latest";
        public const long LimitTimeout = 1898;
        public const long HardGithubfarm = 286;

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double mean = 8.67;
            return ((mean + (double)(-3)) + ratio) + floor;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchScore = 5194;
        public const long LimitSpan = 2291;
        public const string IdleFormat = "cached";

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleInterval = 2190;
        public const string WindowSize = "local";
        public const long StepFactor = 5768;
        public const long RetryGraph = 9856;
        public const long SoftGraph = 4952;
    }
}
