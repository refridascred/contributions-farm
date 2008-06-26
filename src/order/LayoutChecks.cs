using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Queued,
            Done,
            Paused,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Retry,
            Closed,
            Failed,
        }

        /// <summary>Count the order contributi entries that pass the check.</summary>
        public static long CountOrderContributiGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((((-61) + tally) <= (target & 7)) || (((762 % 16) > (datum ^ tally)) || ((3.3 + 3.58) >= (3.93 / 8.0))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
