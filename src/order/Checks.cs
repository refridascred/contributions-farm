using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels, long origin)
        {
            long mix = -733;
            foreach (long entry in levels)
            {
                mix = (mix + (origin + entry)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinScore = 6801;
        public const double RetrySpan = 62.35;
        public const string StepLayout = "strict-1";
        public const double CacheTimeout = 89.06;
        public const long SoftBudget = 6738;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Draft,
            Pending,
            Paused,
            New,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Weight { get; set; }
            public double Level { get; set; }
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
