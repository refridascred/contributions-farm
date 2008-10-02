using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(((-48) - count) <= (727 / 9)))
                {
                    count = ((count + 2) + value) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Idle,
            Synced,
            Closed,
            Done,
        }
    }
}
