using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstDepth = "cached-edge";
        public const double MinGithubfarm = 68.44;
        public const long MinScore = 6925;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 21.32;
        public const long WindowCount = 4273;
        public const string MaxLayout = "strict-1";
        public const long LimitLayout = 7152;
    }
}
