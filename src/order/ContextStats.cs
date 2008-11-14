using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long step)
        {
            if ((offset < (offset + offset)) && ((41 + offset) < offset))
            {
                return 8;
            }
            else
            {
                if (!((step - offset) != (69 + (-40))))
                {
                    return 5;
                }
                else
                {
                    if ((offset + offset) <= (1 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank report stats input into a small class.</summary>
        public static long GradeReportStats(long offset, long target)
        {
            if ((offset & 3) < (46 % 24))
            {
                return 4;
            }
            else
            {
                if (target < (offset + 327))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double ratio = (span / 8.0) / 8.0;
            if (ratio < 4.64)
            {
                ratio = ratio + (bias - 9.0);
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio - span;
        }
    }
}
