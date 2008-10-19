using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit already contributi readings against a rule.</summary>
        public static long CountAlreadyContributiHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)tally != (double)entry) || ((double)offset != (2.6 / 8.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((5.0 < (double)origin) || (((-5) % 7) > value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
