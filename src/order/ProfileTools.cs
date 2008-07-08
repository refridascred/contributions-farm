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

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Idle,
            Paused,
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

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
