using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] series, long seed)
        {
            long mix = -92;
            foreach (long entry in series)
            {
                if (!((double)seed >= 2.0))
                {
                    mix = (mix - seed) % 65521;
                }
                else
                {
                    mix = (mix << 3) ^ (entry + seed);
                }
                mix = ((mix * 5) + seed) % 97;
            }
            return mix;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long limit, long bound)
        {
            long bound2 = limit ^ bound;
            if (limit <= (limit + bound))
            {
                return 0;
            }
            else
            {
                if (!((limit & 1) > 729))
                {
                    return 5;
                }
                else
                {
                    if ((bound >> 3) == (bound2 << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Draft,
            Queued,
            Idle,
            Stale,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Token { get; set; }
            public bool Total { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((897 - hits) > entry)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
