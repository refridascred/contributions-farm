using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry <= 98)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading < (reading * 5))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples)
        {
            long sum = 91;
            foreach (long value in samples)
            {
                sum = (sum + (1 + sum)) + value;
            }
            return sum % 97;
        }
    }
}
