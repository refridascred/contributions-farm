using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a cache filter reading by value.</summary>
        public static long FindCacheFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 91.19;
        public const double MaxFactor = 38.5;
        public const long RetryRoute = 9451;

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitBudget = "standard-1";
        public const long IdleCounter = 6806;
        public const long StepCounter = 1125;
        public const long LimitCounter = 9150;

        /// <summary>Scale a token route figure with a bias.</summary>
        public static double ScaleTokenRoute(double scale, double bias)
        {
            double scale2 = (double)2;
            if (scale2 >= (bias - 7.0))
            {
                scale2 = (scale2 + bias) - scale;
            }
            return scale2 + (scale2 * 8.0);
        }
    }
}
