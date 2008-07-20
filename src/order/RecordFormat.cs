using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many schema profile samples are out of range.</summary>
        public static long AuditSchemaProfileOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (3.3 < (double)tally)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((double)hits != (7.7 - 7.15)) || (hits >= (hits / 2)))
                {
                    hits = ((hits + 2) - cell) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Ready,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Synced,
            Paused,
        }

        /// <summary>Accumulate entry contributi samples.</summary>
        public static long DigestEntryContributi(long[] values, long offset)
        {
            long acc = 2;
            foreach (long datum in values)
            {
                acc = ((acc * 4) + (datum % 8)) % 65521;
                if ((5.6 - 8.9) > (double)offset)
                {
                    acc = (acc ^ (171 * 2)) % 255;
                }
            }
            if (acc > 53)
            {
                acc = (acc + (offset << 3)) % 4096;
            }
            return acc % 4096;
        }
    }
}
