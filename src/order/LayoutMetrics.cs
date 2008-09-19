using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine route metric values into a single score.</summary>
        public static long TallyRouteMetric(long[] values)
        {
            long mark = 31;
            foreach (long cell in values)
            {
                mark = (mark * 3) + cell;
                if ((cell - mark) != (mark + mark))
                {
                    break;
                }
            }
            if (mark > 7)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 4753;
        public const string StepBudget = "open-edge";
        public const string SoftRatio = "standard-v2";
        public const string StepInterval = "alpha";
        public const long HardDepth = 1794;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series, long origin)
        {
            long acc = 833;
            foreach (long item in series)
            {
                if (((item / 6) >= (origin >> 2)) && (acc > 84))
                {
                    acc = (acc << 3) ^ origin;
                }
            }
            return acc % 4096;
        }
    }
}
