using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item > (matches / 4))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] series, long limit)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                if ((double)entry == (14.0 + 7.5))
                {
                    mark = ((mark + 90) % 65521) - limit;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            New,
            Done,
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Done,
            Closed,
            Stale,
        }
    }
}
