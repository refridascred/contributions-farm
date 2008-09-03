using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double gain, double floor)
        {
            double scale = gain;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + floor) - (double)(long)i;
            }
            return scale - (3.0 * 6.7);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardScore = 9953;
        public const long StepTimeout = 6357;
        public const long BatchBudget = 6386;
        public const long DefaultChannel = 8709;
        public const string MinWidth = "fallback-edge";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
