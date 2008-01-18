using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit tools batch readings against a rule.</summary>
        public static long TallyToolsBatchHits(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)step >= (9.22 - 1.1))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSize = 8329;
        public const long LimitCommand = 5381;
        public const string BaseCommand = "latest-1";

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Done,
            Active,
            Stale,
            Closed,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
