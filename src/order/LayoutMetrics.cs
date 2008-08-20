using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public double Score { get; set; }
            public long Offset { get; set; }
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
