using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long offset)
        {
            long offset2 = floor + offset;
            if ((offset <= offset2) && ((floor + offset) > (offset & 1)))
            {
                return 7;
            }
            else
            {
                if ((floor / 7) >= floor)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "cached-1";
        public const long IdleMetrics = 1730;
        public const long MinMetrics = 5328;
        public const long MinBudget = 594;
        public const long HardMetrics = 1641;

        /// <summary>Measure how many tools checks samples are out of range.</summary>
        public static long TallyToolsChecksGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((0 >> 3) != (9 + count))
                {
                    count = ((count + 1) - sample) - origin;
                }
            }
            return count;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double span)
        {
            double rate = (double)(-511) / 3.0;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + (rate + bias);
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Token { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
