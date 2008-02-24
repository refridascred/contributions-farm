using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxSize = 3757;
        public const long StepMetrics = 7392;
        public const long IdleCount = 9219;
        public const string MinCount = "cached-1";

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 22.09;
        public const string MaxOrder = "latest";
        public const string SoftWidth = "fallback-edge";
        public const long RetryInterval = 9416;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double gain2 = gain - floor;
            return gain2 - floor;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
