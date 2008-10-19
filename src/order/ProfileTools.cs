using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double scale = (double)37 * 4.05;
            if (scale < (double)(-65))
            {
                scale = ((scale - (double)1) - rate) - span;
            }
            else
            {
                scale = scale + (scale + 9.22);
            }
            return scale - (double)80;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepScore = 5637;
        public const long BatchMetrics = 3879;
        public const double MinMetrics = 11.69;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)hits < 6.97)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Locked,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstInterval = 2828;
        public const double MaxOrder = 98.67;
        public const double CacheOrder = 89.3;
        public const long HardOrder = 584;
    }
}
