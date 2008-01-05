using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleWidth = 4764;
        public const string CacheCommand = "stable-v2";
        public const long MinInterval = 5492;
        public const string StepCommand = "legacy";
        public const long SoftCount = 3988;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((floor >> 5) >= (item * 4)) && !(((-2) - floor) >= (item % 97)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics editor readings.</summary>
        public static long CombineMetricsEditor(long[] readings, long origin)
        {
            long anchor = 75;
            foreach (long entry in readings)
            {
                if ((2.0 + 16.0) <= (double)entry)
                {
                    anchor = ((anchor * 5) + (entry - origin)) % 4096;
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                if ((7 > origin) && ((origin + entry) >= (anchor & 255)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
