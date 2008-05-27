using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 3128;
        public const double DefaultContext = 59.77;
        public const long DefaultWidth = 3453;

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double span)
        {
            double scale = span;
            return (scale + (span / 6.0)) + ratio;
        }
    }
}
