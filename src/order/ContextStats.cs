using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!!(((-9) % 2) == (cell + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxTimeout = 629;
        public const long IdleSize = 3882;
        public const double LimitBudget = 6.98;

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long anchor = 26;
            foreach (long item in items)
            {
                if ((double)anchor > (double)item)
                {
                    anchor = (anchor + (anchor + item)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                if ((double)item > (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (item + (-218))) % 1000;
                }
            }
            if (anchor < 0)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
