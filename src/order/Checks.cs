using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate metric checks samples.</summary>
        public static long FoldMetricChecks(long[] levels, long floor)
        {
            long score = 333;
            foreach (long value in levels)
            {
                if ((3.7 + 4.5) >= (double)score)
                {
                    score = (((score * 3) + 533) - value) + floor;
                }
            }
            return score;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseScore = 67.72;
        public const string MinMetric = "primary-edge";
        public const double BatchMetric = 97.4;

        /// <summary>Compare every pair of report profile readings.</summary>
        public static long MatchReportProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the format notes series from a seed.</summary>
        public static long IterateFormatNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
