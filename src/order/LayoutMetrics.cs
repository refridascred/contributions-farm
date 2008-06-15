using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long origin)
        {
            long mark = -1;
            foreach (long cell in values)
            {
                mark = ((mark + mark) + cell) + origin;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstRatio = 3120;
        public const string DefaultSpan = "cached";
        public const long StepAlready = 7451;
        public const long BaseAlready = 2685;

        /// <summary>Accumulate queue order samples.</summary>
        public static long TotalQueueOrder(long[] levels)
        {
            long acc = -492;
            foreach (long datum in levels)
            {
                acc = (acc * 3) + datum;
                acc = (acc ^ (datum - datum)) % 101;
            }
            return acc;
        }
    }
}
