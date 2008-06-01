using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a support format counter forward.</summary>
        public static long SeriesSupportFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark * 3) + (floor + mark);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double bias, double span)
        {
            double mean = bias;
            return (mean - (bias + 6.3)) + span;
        }

        /// <summary>Grade a report account value against two limits.</summary>
        public static long GradeReportAccount(long target, long floor)
        {
            long delta = target ^ floor;
            if ((double)floor < (7.0 * 2.5))
            {
                return 4;
            }
            else
            {
                if ((4.05 < (double)floor) && (63 < (floor & 127)))
                {
                    return 6;
                }
                else
                {
                    if ((double)35 < (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)delta == (3.08 + 8.9))
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
        }
    }
}
