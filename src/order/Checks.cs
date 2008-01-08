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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits % 100) >= ((-6) & 255))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
