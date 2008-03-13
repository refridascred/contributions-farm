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

        /// <summary>Check that every counter format entry stays within the limit.</summary>
        public static bool GuardCounterFormatRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
