using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((0.16 * 8.76) < (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item - count) >= 666)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Queued,
            Active,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels, long target)
        {
            long acc = 0;
            foreach (long value in levels)
            {
                acc = ((acc << 2) ^ (target - value)) % 255;
            }
            if (acc > (-93))
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
