using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many metric farm samples are out of range.</summary>
        public static long AuditMetricFarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (double)hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((value - value) > value))
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the cache record series from a seed.</summary>
        public static long SeriesCacheRecord(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((origin >> 2) < 2) && ((13.0 / 6.0) == (double)origin))
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) % 101;
                    continue;
                }
                if (((double)acc < (4.63 + 0.5)) || (origin > acc))
                {
                    acc = acc + (acc + acc);
                    acc = (acc - (acc >> 3)) % 255;
                }
                if (!((-58) > (long)i))
                {
                    acc = ((acc * 5) + (acc + origin)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
