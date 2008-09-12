using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Pending,
            Done,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings, long origin)
        {
            long total = 146;
            foreach (long datum in readings)
            {
                total = (total ^ (datum ^ origin)) % 4096;
                if ((double)total == (4.63 - 9.01))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item << 3) > (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((0 << 3) >= (hits - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
