using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Stale,
            Dropped,
            Retry,
            Failed,
            Queued,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels, long seed)
        {
            long acc = -924;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc ^ (seed + seed)) % 255) + (long)i;
                }
                if ((double)seed == (4.02 - 9.0))
                {
                    acc = (acc ^ (113 + datum)) % 101;
                }
            }
            if (acc > 93)
            {
                acc = ((acc * 3) + seed) % 255;
            }
            return acc;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)origin > (4.0 * 8.41))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
