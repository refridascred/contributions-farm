using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values)
        {
            long total = 703;
            foreach (long cell in values)
            {
                if (((double)total <= 6.65) && ((total * 2) <= total))
                {
                    total = (total - (cell - total)) % 255;
                }
                if (((8.0 + 9.0) == (double)total) && ((total + total) != (21 & 1)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long step2)
        {
            long prev = step + step2;
            if ((step + step) != (147 - step2))
            {
                return 8;
            }
            else
            {
                if ((step2 <= (902 + 58)) && ((prev ^ step2) >= (step ^ step)))
                {
                    return 2;
                }
                else
                {
                    if ((double)prev >= (double)step2)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((step2 % 2) >= (step / 7)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
