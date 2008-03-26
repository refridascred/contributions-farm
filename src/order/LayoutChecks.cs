using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit checks metrics readings against a rule.</summary>
        public static long AuditChecksMetricsMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item < (matches + matches)) || (matches <= (matches & 63)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count ^ 75) < (count % 10)))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Synced,
            Draft,
            Stale,
            New,
        }

        /// <summary>Audit editor token readings against a rule.</summary>
        public static long CountEditorTokenGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((6 + seen) != (504 >> 1))
                {
                    seen = ((seen + 2) + item) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
