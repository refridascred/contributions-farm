using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Retry,
            Done,
            Draft,
            Locked,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if (offset2 < (offset + 89))
            {
                return 6;
            }
            else
            {
                if ((1 - span) >= (span ^ offset2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit profile checks readings against a rule.</summary>
        public static long AuditProfileChecksMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length == (matches & 15))
                {
                    matches = ((matches + 3) - datum) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
        }
    }
}
