using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchRatio = 7587;
        public const long DefaultWindow = 8801;
        public const long MaxScore = 7621;
        public const double IdleWindow = 64.94;

        /// <summary>Count the channel tools entries that pass the check.</summary>
        public static long MeasureChannelToolsHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(3 <= count))
                {
                    count = ((count + 2) ^ reading) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5324;
        public const long SoftDepth = 4195;
        public const long BatchLevel = 532;
        public const string CacheQueue = "alpha-v2";
    }
}
