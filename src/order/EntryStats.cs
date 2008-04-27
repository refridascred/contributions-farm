using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + limit) < (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] series)
        {
            long sum = 9;
            foreach (long item in series)
            {
                if ((item / 7) > (item ^ item))
                {
                    sum = sum - (-9);
                }
            }
            if (sum < 9)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }
    }
}
