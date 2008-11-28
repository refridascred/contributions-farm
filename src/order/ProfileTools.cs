using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowInterval = "standard-v2";
        public const long BaseFarm = 9001;
        public const long LimitFarm = 5286;
        public const long RetryFarm = 402;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Pending,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "cached-v2";
        public const string IdleSize = "latest-v2";
        public const double WindowDepth = 16.42;
        public const double SoftTimeout = 25.56;
    }
}
