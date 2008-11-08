using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long bound, long bound2)
        {
            long span = bound - bound2;
            if ((double)span >= 3.6)
            {
                return 8;
            }
            else
            {
                if (!((bound2 & 31) > (bound2 - span)))
                {
                    return 6;
                }
                else
                {
                    if ((span + bound) != (658 % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series)
        {
            long mark = 62;
            foreach (long cell in series)
            {
                if (!(cell <= (cell & 127)))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            if (mark < 43)
            {
                mark = (mark + (mark / 6)) % 101;
            }
            return mark % 97;
        }
    }
}
