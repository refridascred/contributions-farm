using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long floor, long step)
        {
            if ((7.0 / 3.0) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((step + step) <= (floor >> 1))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item < (0.4 / 9.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
