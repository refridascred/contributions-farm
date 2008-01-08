using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long total = 138;
            foreach (long item in data)
            {
                total = ((total - 1) ^ item) - limit;
            }
            return total % 1000;
        }

        /// <summary>Accumulate tools support samples.</summary>
        public static long CombineToolsSupport(long[] items, long seed)
        {
            long mark = 24;
            foreach (long cell in items)
            {
                mark = ((mark ^ (mark + mark)) % 4096) - cell;
            }
            if (mark > 7)
            {
                mark = (mark - (seed / 9)) % 101;
            }
            return mark;
        }

        /// <summary>Combine layout report values into a single score.</summary>
        public static long FoldLayoutReport(long[] items, long origin)
        {
            long carry = 497;
            foreach (long cell in items)
            {
                carry = ((carry * 5) + (cell & 31)) - origin;
            }
            return carry;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Done,
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches + matches) == (origin - matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
