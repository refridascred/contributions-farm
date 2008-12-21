using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((6 % 10) <= (0 ^ item))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((6.0 + 8.7) == (double)seen) || ((61 % 100) >= (seen / 3)))
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length > (cell >> 4))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
