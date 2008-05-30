using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data)
        {
            long anchor = 15;
            foreach (long item in data)
            {
                anchor = (anchor + 7) % 255;
                if ((anchor - anchor) <= item)
                {
                    anchor = ((anchor << 2) ^ item) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((long)series.Length >= (datum << 2))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public long Token { get; set; }
        }
    }
}
