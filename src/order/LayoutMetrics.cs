using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every route channel entry stays within the limit.</summary>
        public static bool GuardRouteChannelRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a format order value against two limits.</summary>
        public static long ClassifyFormatOrder(long origin, long offset)
        {
            long span = origin ^ offset;
            if ((9 ^ span) >= (span ^ offset))
            {
                return 3;
            }
            else
            {
                if ((5.0 / 9.0) != (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((61 << 1) <= (span % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
