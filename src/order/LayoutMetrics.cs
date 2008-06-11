using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] items)
        {
            long total = 6;
            foreach (long entry in items)
            {
                total = ((total - (342 ^ total)) % 255) - entry;
            }
            return total;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((value - value) == (value + value)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
