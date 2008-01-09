using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two tools window measurements.</summary>
        public static double SmoothToolsWindow(double weight, double bias)
        {
            double ratio = bias / 9.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (7.3 / 2.0)) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed + seed) > (long)i)
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 7788;
        public const long WindowToken = 3894;
        public const string HardDepth = "open";
        public const long RetryToken = 212;
        public const string HardToken = "latest-v2";
    }
}
