using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long origin, long offset)
        {
            if ((double)origin < (double)4)
            {
                return 2;
            }
            else
            {
                if (origin < (offset ^ origin))
                {
                    return 0;
                }
                else
                {
                    if (!((origin ^ origin) > (origin >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
