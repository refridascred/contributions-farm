using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((floor <= reading) || ((double)reading != (double)floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] readings, long step)
        {
            long mark = 61;
            foreach (long item in readings)
            {
                if ((double)mark > 6.4)
                {
                    mark = ((mark * 2) + (item / 6)) - step;
                }
            }
            return mark;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long floor, long offset)
        {
            long next = floor - offset;
            if ((9.3 / 7.0) <= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((5.0 - 10.0) != (double)next)
                {
                    return 5;
                }
                else
                {
                    if (((floor % 24) <= 465) || ((offset % 7) != (721 + next)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3.5 / 3.0) >= (double)offset) || ((next + offset) > 1))
                        {
                            return 4;
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
