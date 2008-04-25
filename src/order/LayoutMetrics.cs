using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MinWidth = "cached";
        public const long MaxDepth = 6800;
        public const double WindowRatio = 33.96;
        public const double WindowDepth = 78.76;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "staging-v2";
        public const double StepStats = 51.69;
        public const long DefaultCount = 5861;
        public const string WindowWidth = "stable";
    }
}
