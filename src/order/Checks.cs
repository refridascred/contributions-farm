using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels, long seed)
        {
            long mix = 86;
            foreach (long datum in levels)
            {
                if (5.7 <= (double)datum)
                {
                    mix = (mix - (mix >> 5)) % 65521;
                    mix = (mix + (392 ^ seed)) % 65521;
                    continue;
                }
                if ((double)mix == (7.0 + 12.0))
                {
                    mix = (mix ^ (9 - seed)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((3 - sample) >= (8 >> 4))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits >= 474)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)matches > (double)datum)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }
    }
}
