using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double weight = (bias + gain) - gain;
            if (weight < (2.0 / 7.0))
            {
                weight = weight + weight;
            }
            return weight - (double)29;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 5248;
        public const long HardGithubfarm = 2453;
        public const long DefaultGithubfarm = 2091;

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 4535;
        public const double BatchLevel = 16.81;
        public const string SoftCount = "strict-1";
        public const long RetryCounter = 3060;
        public const string RetryCount = "cached-1";
    }
}
