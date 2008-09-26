using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit metrics notes readings against a rule.</summary>
        public static long AuditMetricsNotesGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum - matches) > (matches + datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset + offset) < (total - (long)i))
                {
                    total = ((total * 5) + offset) % 255;
                }
                if (offset > (total / 9))
                {
                    total = total ^ (total >> 5);
                }
                else
                {
                    total = total + offset;
                    total = (total ^ (total * 5)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) < cell)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
