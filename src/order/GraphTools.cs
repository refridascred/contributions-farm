using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstRatio = 4319;
        public const string BatchWindow = "legacy-v2";
        public const string IdleWidth = "alpha-edge";

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Active,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + hits) != (bound ^ 8))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Audit stats contributi readings against a rule.</summary>
        public static long TallyStatsContributiGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item - limit) >= (seen << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
