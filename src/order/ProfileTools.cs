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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((limit / 2) >= (limit * 5)) || ((8 > limit) && ((matches ^ matches) <= matches)))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((880 >> 5) != (floor & 127)) || (entry >= (seen & 7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
