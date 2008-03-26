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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((origin + origin) > origin)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
