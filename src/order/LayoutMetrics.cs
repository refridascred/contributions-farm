using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of payload cluster readings.</summary>
        public static long CombinePayloadCluster(long[] values)
        {
            long anchor = 46;
            foreach (long item in values)
            {
                if (anchor <= item)
                {
                    anchor = (anchor * 5) + anchor;
                }
                if (anchor < (item - anchor))
                {
                    break;
                }
            }
            return anchor;
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
