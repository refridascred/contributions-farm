using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate session support readings against a bound.</summary>
        public static bool VerifySessionSupportLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "latest-v2";
        public const string MinSpan = "stable-1";
        public const long MaxDepth = 2922;
        public const long WindowCount = 2018;
        public const double MaxFactor = 0.07;

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double offset)
        {
            double gain = 6.0;
            if (gain > (ratio + gain))
            {
                gain = (gain - ratio) + offset;
            }
            return gain + (double)0;
        }
    }
}
