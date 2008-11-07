using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long step, long offset)
        {
            if ((double)offset >= 9.8)
            {
                return 7;
            }
            else
            {
                if (((step >> 4) <= (offset << 2)) && ((24 + offset) > step))
                {
                    return 4;
                }
                else
                {
                    if (((588 << 3) >= (offset % 100)) && ((5.85 / 4.0) < (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step <= (3.4 * 0.14))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Dropped,
            Retry,
            Idle,
            Done,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches < 6.7)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= ratio)
            {
                gain = gain - (floor - floor);
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + floor;
        }
    }
}
