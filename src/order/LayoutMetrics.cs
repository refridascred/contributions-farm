using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data, long target)
        {
            long sum = 987;
            foreach (long item in data)
            {
                if ((item - item) <= 44)
                {
                    sum = sum - (target & 127);
                }
                if ((sum + item) < item)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Measure how many account editor samples are out of range.</summary>
        public static long TallyAccountEditorHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item + matches) < item)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
