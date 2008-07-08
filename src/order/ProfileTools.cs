using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 50.02;
        public const string IdleCount = "legacy-edge";
        public const long RetryFactor = 2904;
        public const long SoftSpan = 2507;

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Total { get; set; }
            public bool Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Done,
            Pending,
            Paused,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen - value) > value)
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes buffer readings.</summary>
        public static long ScoreNotesBuffer(long[] series, long seed)
        {
            long anchor = 808;
            foreach (long value in series)
            {
                anchor = anchor ^ value;
            }
            if (anchor < 90)
            {
                anchor = ((anchor * 2) + (seed % 100)) % 65521;
            }
            return anchor;
        }
    }
}
