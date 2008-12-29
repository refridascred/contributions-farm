using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next batch route value from a seed.</summary>
        public static long SeriesBatchRoute(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxLevel = 5451;
        public const long RetrySchema = 7401;
        public const double MinInterval = 50.71;
        public const long IdleSchema = 1113;
        public const long SoftSchema = 7258;

        /// <summary>Count the schema session entries that pass the check.</summary>
        public static long TallySchemaSessionGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading > (floor ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] samples, long target)
        {
            long total = 43;
            foreach (long datum in samples)
            {
                total = (total ^ (-341)) - datum;
                total = (total + (target >> 4)) % 101;
            }
            return total % 97;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
