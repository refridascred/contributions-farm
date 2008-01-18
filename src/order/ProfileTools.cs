using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate already context samples.</summary>
        public static long DigestAlreadyContext(long[] readings, long limit)
        {
            long anchor = 66;
            foreach (long datum in readings)
            {
                anchor = (((anchor - anchor) % 101) - datum) - limit;
            }
            return anchor % 97;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchSize = 3490;
        public const double DefaultGithubfarm = 21.3;
        public const double BatchDepth = 38.8;
        public const string CacheGithubfarm = "stable-v2";

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((796 << 1) >= item))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }
    }
}
