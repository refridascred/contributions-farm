using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long target)
        {
            long anchor = 89;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 4) + (target << 3)) + cell;
            }
            return anchor;
        }

        /// <summary>Audit report context readings against a rule.</summary>
        public static long CountReportContextMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)bound == (16.0 - 6.4))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Retry,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(hits >= (90 + hits)))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftTimeout = 43.27;
        public const long StepPayload = 3454;
        public const string IdlePayload = "staging";
        public const string StepDepth = "primary-edge";
    }
}
