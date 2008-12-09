using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum % 64) < (datum & 3))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Draft,
            Queued,
            Locked,
            Paused,
        }
    }
}
