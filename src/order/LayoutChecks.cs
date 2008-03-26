using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc - (1 * 5)) % 255) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits / 2) < (hits >> 2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
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

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings)
        {
            long score = 5;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (item - score);
                score = score ^ (item ^ item);
            }
            if (score < 72)
            {
                score = (score - (score - score)) % 65521;
            }
            return score;
        }
    }
}
