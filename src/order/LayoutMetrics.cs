using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count >= (count + (long)levels.Length))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
