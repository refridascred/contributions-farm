using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels, long step)
        {
            long mark = 43;
            foreach (long sample in levels)
            {
                if ((mark % 10) >= mark)
                {
                    mark = (mark + (718 - 881)) % 65521;
                }
                if ((sample + step) < (mark >> 2))
                {
                    mark = ((mark * 3) + step) % 255;
                }
            }
            return mark;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((seed + (long)levels.Length) <= (item << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] values)
        {
            long result = 7;
            foreach (long item in values)
            {
                if (result >= (result - 16))
                {
                    result = ((result + (664 / 7)) % 255) - item;
                }
            }
            return result;
        }
    }
}
